@extends('layouts.app')

@section('content')

    <div class="panelBackground panel-default">
        @if($post->is_allowed == 1)
            <div class="panel-heading">
                <h1>{{ $post->title }}</h1>
                <p class="forumTitleUnder"><b>{{ $post->user->username }}</b> schreef op {{ $post->created_at->formatLocalized('%d %B') }} | {{ $post->comments()->where('is_allowed', '=', 1)->count() }} @if($post->comments()->where('is_allowed', '=', 1)->count() == 1) reactie @else reacties @endif</p>
                <div class="addCommentButton">
                    @if(\Auth::check()) 
                        <a href="{{ route('create_comment_path', ['post' => $post->id]) }}">Een reactie toevoegen</a>
                    @else
                        <a href="{{ route('login') }}">Login om te reageren</a>
                    @endif
                </div>
            </div>
            <div class="backButton">
                <a href="/forum">&larr; Terug naar overzicht</a>
            </div>
            <div class="panel-body">
                <div class="fullPost">
                    
                    @if($post->wasCreatedBy( Auth::user() ))
                        <div class="description">
                            <p>{{ $post->description }}</p>
                        </div>
                    
                        <div class="managePost">
                            <small class="pull-right">
                                <a href="{{ route('edit_post_path', ['post' => $post->id]) }}" class="btn btn-info"><i class='fas fa-pencil-alt'></i></a>
                            </small>
                            <small class="pull-right">
                                <form action="{{ route('delete_post_path', ['post' => $post->id]) }}" method="POST">
                                    {{ csrf_field() }}
                                    {{ method_field('DELETE') }}
                                    <button type="submit" class="btn btn-danger"><i class='fa fa-trash'></i></button>
                                </form>
                            </small>
                        </div>

                    @else
                        <div class="descriptionFullWidth">
                            <p>{{ $post->description }}</p>
                        </div>
                    @endif
                    
                </div>

                <div class="comments">
                    <ul>
                        @foreach($post->comments as $comment)
                            @if($comment->is_allowed == 1)
                                <li>
                                    <div class="commentHeader">
                                        <img src="/img/AvatarPlaceholder.png" alt="Anoniem" class="commentAvatar">
                                        <h3>{{ $comment->user->username }}</h3>
                                    </div>
                                    <div class="commentBody clearfix">
                                        
                                        @if($comment->wasCreatedBy( Auth::user() ))
                                            <div class="commentText">
                                                {{ $comment->comment }}
                                            </div>
                                            <div class="manageComment"> 
                                                <small class="pull-right">
                                                    <a href="{{ route('edit_comment_path', ['comment' => $comment->id]) }}" class="btn btn-info"><i class='fas fa-pencil-alt'></i></a>
                                                </small>
                                                <small class="pull-right" style="margin-right: 10px;">
                                                    <form action="{{ route('delete_comment_path', ['post' => $post->id, 'comment' => $comment->id]) }}" method="POST">
                                                        {{ csrf_field() }}
                                                        {{ method_field('DELETE') }}
                                                        <button type="submit" class="btn btn-danger"><i class='fa fa-trash'></i></button>
                                                    </form>
                                                </small>
                                            </div>
                                        @else
                                            <div class="commentTextFullWidth">
                                                {{ $comment->comment }}
                                            </div>
                                        @endif
                                        
                                    </div>
                                    <div class="commentFooter">
                                        Reactie toegevoegd op {{ $comment->created_at->formatLocalized('%d %B') }}
                                    </div>
                                </li>
                            @endif
                        @endforeach
                    </ul>
                    <div class="commentsPlaceholder">

                    </div>
                </div>
            </div>
        @endif
    </div>


@stop
