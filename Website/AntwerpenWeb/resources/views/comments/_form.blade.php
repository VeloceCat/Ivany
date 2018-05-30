<div id="comment-form" class="col-md-8 col-md-offset-2">
    @if($comment->exists)
        <form action="{{ route('update_comment_path', ['comment' => $comment->id]) }}" method="POST">
        <h2>Reactie bewerken</h2>
            {{ method_field('PUT') }}
    @else
        <form action="{{ route('store_comment_path', ['post' => $post->id]) }}" method="POST">
        <h2>Reactie toevoegen</h2>
    @endif

        {{ csrf_field() }}

        <div class="form-group">
            <label for="title">Reactie:</label>
            <textarea rows="5" name="comment" class="form-control"/>{{ $comment->comment or old('comment') }}</textarea>
        </div>
   
        <div class="confirmButtons">
            @if($comment->exists)
                <div class="form-group">
                    <button type="submit" class='btn btn-success'>Reactie bewerken</button>
                </div>
            @else
                <div class="form-group">
                    <button type="submit" class='btn btn-success'>Reactie toevoegen</button>
                </div>
            @endif
            <div class="form-group">
                <a href="javascript:history.back()" class='btn btn-primary'>Annuleren</a>
            </div>
        </div>
        
    </form>
    <div class="form-group">
        @if($comment->wasCreatedBy( Auth::user() ))
            <small class="pull-right">
                <form action="{{ route('delete_comment_path', ['comment' => $comment->id]) }}" method="POST">
                    {{ csrf_field() }}
                    {{ method_field('DELETE') }}
                    <button type="submit" class="btn btn-danger">Verwijderen</button>
                </form>
            </small>
        @endif
    </div>
</div>