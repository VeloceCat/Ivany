<?php

namespace App\Http\Controllers;

use App\Post;
use App\Comment;
use Illuminate\Http\Request;
use App\Http\Requests\CreatePostRequest;
use App\Http\Requests\UpdatePostRequest;

class PostsController extends Controller
{
    public function forum()
    {
        $posts = Post::with('user')->orderBy('id', 'desc')->paginate(10);

        return view('posts.forum')->with(['posts' => $posts]);
    }


    public function show(Post $post, Comment $comment)
    {
        $comments = Comment::with('post')->orderBy('id', 'desc');
        //$comments = Comment::all();

        return view('posts.show')->with(['post' => $post, 'comment' => $comment, 'comments' => $comments]);
    }


    public function create()
    {
        $post = new Post;

        $post->is_allowed = 0;
        
        return view('posts.create')->with(['post' => $post]);
    }


    public function store(CreatePostRequest $request)
    {
        $post = new Post;

        $post->fill(
            $request->only('title', 'description')
        );

        $post->user_id = $request->user()->id;
        $post->is_allowed = 0;

        $post->save();

        session()->flash('message', 'Je post wordt zo snel mogelijk gecontroleerd, hij staat binnenkort online.');

        return redirect()->route('posts_path');
    }


    public function edit(Post $post)
    {
        if($post->user_id != \Auth::user()->id) {
            return redirect()->route('posts_path');
        }

        $post->is_allowed = 0;

        return view('posts.edit')->with(['post' => $post]);
    }


    public function update(Post $post, UpdatePostRequest $request)
    {
        $post->is_allowed = 0;

        $post->update(
            $request->only('title', 'description')
        );

        session()->flash('message', 'Je post is bijgewerkt. Hij wordt zo snel mogelijk gecontroleerd en staat binnenkort weer online.');

        return redirect()->route('posts_path', ['post' => $post->id]);
    }


    public function delete(Post $post)
    {
        if($post->user_id != \Auth::user()->id) {
            return redirect()->route('posts_path');
        }

        $post->is_allowed = 0;

        $post->delete();

        session()->flash('message', 'Je post is verwijderd.');

        return redirect()->route('posts_path');
    }
}

