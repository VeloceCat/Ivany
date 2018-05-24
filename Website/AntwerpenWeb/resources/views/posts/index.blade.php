@extends('layouts.app')

@section('content')

        <div class="panel panel-default">
            <div class="panel-heading">
                Article overview
            </div>
            @if(\Auth::check()) 
                <a href="{{ route('create_post_path') }}">Add article</a>
            @endif
            <div class="panel-content">
                <ul class="article-overview">
                    @foreach($posts as $post)
                        <div class="url">
                            <a href="{{ $post->url }}" target="_blank" class="urlTitle">{{ $post->title }}</a>

                            @if($post->wasCreatedBy( Auth::user() ))
                                <small class="pull-right">
                                    <a href="{{ route('edit_post_path', ['post' => $post->id]) }}" class="btn btn-info">Edit</a>
                                </small>
                            @endif
                        </div>
                        <div class="info">
                            <p>Posted by <b>{{ $post->user->name }}</b> | <a href="{{ route('post_path', ['post' => $post->id]) }}">{{ $post->comments()->count() }} comments</a></p>
                        </div>
                    @endforeach
                </ul>
            </div>
        </div>

    {{ $posts->render() }}

@stop