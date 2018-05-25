@extends('layouts.app')

@section('content')

    <div class="breadcrumb">
        <a href="/forum">&larr; back to overview</a>
    </div>

    <div class="panel panel-default">
        <div class="panel-heading clearfix">
            Article: {{ $post->title }}
        </div>
        <div class="panel-content">
            <div class="post">
                <a href="{{ route('post_path', ['post' => $post->id]) }}">{{ $post->title }}</a>

                @if($post->wasCreatedBy( Auth::user() ))
                    <small class="pull-right">
                        <a href="{{ route('edit_post_path', ['post' => $post->id]) }}" class="btn btn-info">Edit</a>
                    </small>
                @endif
            </div>
            <div class="info">
                @if (Auth::user()->is_admin === 1 || $post->wasCreatedBy(Auth::user()) || $post->user->is_admin === 1)
                    <p>Geplaatst door <b>{{ $post->user->name }}</b> op {{ $post->created_at }} | {{ $post->comments()->count() }} reacties</p>
                @else
                    <p>Geplaatst door <b>anoniem</b> op {{ $post->created_at }} | {{ $post->comments()->count() }} reacties</p>
                @endif
            </div>
            <div class="description">
                <br>
                <p><b>Description:</b></p>
                {{ $post->description }}
            </div>
        </div>

        <div class="comments">
            <ul>
                @foreach($post->comments as $comment)
                    <li>
                        <div class="comment-body clearfix">
                            <div class="comment-text">
                                {{ $comment->comment }}
                            </div>
                            <div style="margin-right: 40px;">
                                @if($comment->wasCreatedBy( Auth::user() ))
                                    <small class="pull-right">
                                        <a href="{{ route('edit_comment_path', ['comment' => $comment->id]) }}" class="btn btn-info">Aanpassen</a>
                                    </small>

                                    <small class="pull-right" style="margin-right: 10px;">
                                        <form action="{{ route('delete_comment_path', ['post' => $post->id, 'comment' => $comment->id]) }}" method="POST">
                                            {{ csrf_field() }}
                                            {{ method_field('DELETE') }}
                                            <button type="submit" class="btn btn-danger">Verwijderen</button>
                                        </form>
                                    </small>
                                @endif
                            </div>
                        </div>
                        <div class="comment-info">
                            @if (Auth::user()->is_admin === 1 || $post->wasCreatedBy(Auth::user()) || $comment->user->is_admin === 1)
                                Geplaatst door <b>{{ $comment->user->name }}</b> op {{ $comment->created_at }}
                            @else
                                Geplaatst door <b>anoniem</b> op {{ $comment->created_at }}
                            @endif
                        </div>
                    </li>
                @endforeach
            </ul>
            <div style="margin-left: 40px;">
                @if(\Auth::check()) 
                    <a href="{{ route('create_comment_path', ['post' => $post->id]) }}" class="btn btn-success">Reactie plaatsen</a>
                @else
                    <p>Je moet <a href="{{ route('login') }}">in gelogd zijn</a> om en reactie te plaatsen.</p>
                @endif
            </div>
        </div>
    </div>


@stop
