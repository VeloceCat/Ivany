@extends('layouts.app')

@section('content')

        <div class="panelBackground panel-default">
            <div class="panel-heading">
                <h1>Welkom op ons forum</h1>
                <p class="forumTitleUnder">Vertel anderen over jouw ervaringen. Bovendien blijf je anoniem.</p>
                <div class="addPostButton">
                    @if(\Auth::check()) 
                        <a href="{{ route('create_post_path') }}">Voeg hier een post toe</a>
                    @else
                        <a href="{{ route('login') }}">Login om een post toe te voegen</a>
                    @endif
                </div>
            </div>
            
            <div class="panel-body">
                <div class="article-overview">
                    @foreach($posts as $post)
                        <div class="post">
                            <div class="postHeader">
                                <img src="/img/AvatarPlaceholder.png" alt="Anoniem" class="postAvatar">
                                <h2>{{ $post->user->name }}</h2>
                            </div>
                            <div class="postBody">
                                <div class="postContent">
                                    <div class="postTitle">
                                        <a href="{{ route('post_path', ['post' => $post->id]) }}">{{ $post->title }}</a>
                                    </div>
                                    <div class="postText">
                                        <?php 
                                            $shortendText = substr($post->description, 0, 50); 
                                            echo "<p>$shortendText ...</p>";
                                        ?>
                                    </div>
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
                            <div class="postFooter">
                                <p>Gepost op {{ $post->created_at->formatLocalized('%d %B') }} | <a href="{{ route('post_path', ['post' => $post->id]) }}">{{ $post->comments()->count() }} @if($post->comments()->count() == 1) reactie @else reacties @endif</a></p>
                            </div>
                        </div>
                    @endforeach
                </div>
            </div>
        </div>

    {{ $posts->render() }}

@stop