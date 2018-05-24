<div id="comment-form" class="col-md-8 col-md-offset-2">
    @if($comment->exists)

        <form action="{{ route('update_comment_path', ['comment' => $comment->id]) }}" method="POST">
            {{ method_field('PUT') }}

    @else

        <form action="{{ route('store_comment_path', ['post' => $post->id]) }}" method="POST">

    @endif

        {{ csrf_field() }}

        <div class="form-group">

            <label for="title">Comment:</label>
            <textarea rows="5" name="comment" class="form-control"/>{{ $comment->comment or old('comment') }}</textarea>
        </div>

        
        
        @if($comment->exists)
            <div class="form-group">
                <button type="submit" class='btn btn-primary'>Edit Comment</button>
            </div>
        @else
            <div class="form-group">
                <button type="submit" class='btn btn-primary'>Add Comment</button>
            </div>
        @endif
        
    </form>
    <div class="form-group">
        @if($comment->wasCreatedBy( Auth::user() ))
            <small class="pull-right">
                <form action="{{ route('delete_comment_path', ['comment' => $comment->id]) }}" method="POST">
                    {{ csrf_field() }}
                    {{ method_field('DELETE') }}
                    <button type="submit" class="btn btn-danger">Delete</button>
                </form>
            </small>
        @endif
    </div>
</div>