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
        $post= Post::find($id);

        $comment = new Comment;

        $comment->comment = $request->comment;
        $comment->post()->associate($post);

        $comment->user_id = $request->user()->id;

        $comment->save();

        session()->flash('message', 'Comment Created!');

        return redirect()->route('post_path', [$post->post]);
    }

   
    public function edit($id) 
    {
        $comment = Comment::find($id);

        return view('comments.edit')->with(['comment' => $comment]);
    }

    public function update(Request $request, $id)
    {
        $comment = Comment::find($id);

        $comment->comment = $request->comment;
        $comment->save();

        session()->flash('message', 'Comment Updated!');

        return redirect()->route('posts_path', $comment->post->id);
    }

    public function delete(Comment $comment)
    {
        if($comment->user_id != \Auth::user()->id) {
            session()->flash('message', 'No permission!');
            
            return redirect()->route('posts_path');
        }

        $comment->delete();

        session()->flash('message', 'Comment Deleted!');

        return redirect()->route('posts_path');
    }

    
}
