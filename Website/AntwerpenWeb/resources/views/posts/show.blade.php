@extends('layouts.app')

@section('content')
    <div class="panelBackground panel-default">
        <div class="panel-heading">
            <h1>{{ $post->title }}</h1>
            <p class="forumTitleUnder"><b>{{ $post->user->name }}</b> schreef op {{ $post->created_at->formatLocalized('%d %B') }} | {{ $post->comments()->count() }} @if($post->comments()->count() == 1) reactie @else reacties @endif</p>
            <div class="addCommentButton">
                @if(\Auth::check()) 
                    <a href="{{ route('create_comment_path', ['post' => $post->id]) }}">Een reactie toevoegen</a>
                @else
                    <a href="{{ route('login') }}">Login om te reageren</a>
                @endif
            </div>
<<<<<<< HEAD
=======
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
>>>>>>> f688386756557a83c6f7e3729434126482322ae3
        </div>
        <div class="backButton">
            <a href="/forum">&larr; Terug naar overzicht</a>
        </div>
        <div class="panel-body">
            <div class="fullPost">
                <div class="description">
                    <p>{{ $post->description }}</p>
                </div>
                <div class="managePost">
                    @if($post->wasCreatedBy( Auth::user() ))
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
                    @endif
                </div>
            </div>

            <div class="comments">
                <ul>
                    @foreach($post->comments as $comment)
                        <li>
                            <div class="commentHeader">
                                <img src="/img/AvatarPlaceholder.png" alt="Anoniem" class="commentAvatar">
                                <h3>{{ $comment->user->name }}</h3>
                            </div>
<<<<<<< HEAD
                            <div class="commentBody clearfix">
                                <div class="commentText">
                                    {{ $comment->comment }}
                                </div>
                                <div class="manageComment">
                                    @if($comment->wasCreatedBy( Auth::user() ))
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
                                    @endif
                                </div>
                            </div>
                            <div class="commentFooter">
                                Reactie toegevoegd op {{ $comment->created_at->formatLocalized('%d %B') }}
                            </div>
                        </li>
                    @endforeach
                </ul>
=======
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
>>>>>>> f688386756557a83c6f7e3729434126482322ae3
            </div>
        </div>
    </div>


@stop
