<?php

namespace App\Http\Controllers;

use App\Comment;
use App\Post;
use Illuminate\Http\Request;
use App\Http\Requests\CreateCommentRequest;


class CommentsController extends Controller
{

    public function create($id)
    {
        $post= Post::find($id);

        $comment = new Comment;

        return view('comments.create')->with(['comment' => $comment, 'post' => $post]);
    }

    public function store(CreateCommentRequest $request, $id) 
    {
        $post = Post::find($id);

        $comment = new Comment;

        $comment->comment = $request->comment;
        $comment->post()->associate($post);

        $comment->user_id = $request->user()->id;
        $comment->is_allowed = 0;

        $comment->save();

        session()->flash('message', 'Je reactie wordt zo snel mogelijk gecontroleerd, ze staat binnenkort online.');

        return redirect()->route('post_path', [$post->post]);
    }

   
    public function edit($id) 
    {
        $comment = Comment::find($id);
        $comment->is_allowed = 0;

        return view('comments.edit')->with(['comment' => $comment]);
    }

    public function update(Request $request, $id)
    {
        $comment = Comment::find($id);

        $comment->comment = $request->comment;
        $comment->is_allowed = 0;

        $comment->save();

        session()->flash('message', 'Je reactie is bijgewerkt. Ze wordt zo snel mogelijk gecontroleerd, hij staat binnenkort weer online.');

        return redirect()->route('post_path', $comment->post->id);
    }

    public function delete(Comment $comment)
    {
        if($comment->user_id != \Auth::user()->id) {
            session()->flash('message', 'No permission!');
            
            return redirect()->route('posts_path');
        }
        
        $comment->is_allowed = 0;
        $comment->delete();

        session()->flash('message', 'Je reactie is verwijderd.');

        return redirect()->route('posts_path');
    }
}
