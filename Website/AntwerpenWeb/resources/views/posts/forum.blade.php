@extends('layouts.app')

@section('content')

        <div class="panel panel-default">
            <div class="panel-heading">
                Forum overzicht
            </div>
            @if(\Auth::check()) 
                <a href="{{ route('create_post_path') }}">Post plaatsen</a>
            @endif
            <div class="panel-content">
                <ul class="article-overview">
                    @foreach($posts as $post)
                        <div class="post">
                            <a href="{{ route('post_path', ['post' => $post->id]) }}">{{ $post->title }}</a>

                            @if($post->wasCreatedBy( Auth::user() ))
                                <small class="pull-right">
                                    <a href="{{ route('edit_post_path', ['post' => $post->id]) }}" class="btn btn-info">Aanpassen</a>
                                </small>
                            @endif
                        </div>
                        <div class="info">
                            @if (Auth::user()->is_admin === 1 || $post->wasCreatedBy(Auth::user()) || $post->user->is_admin === 1)
                                <p>Geplaatst door <b>{{ $post->user->name }}</b> | <a href="{{ route('post_path', ['post' => $post->id]) }}">{{ $post->comments()->count() }} reacties</a></p>
                            @else
                                <p>Geplaatst door <b>anoniem</b> | <a href="{{ route('post_path', ['post' => $post->id]) }}">{{ $post->comments()->count() }} reacties</a></p>
                            @endif
                        </div>
                    @endforeach
                </ul>
            </div>
        </div>

    {{ $posts->render() }}

@stop