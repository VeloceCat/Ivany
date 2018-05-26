<div id="post-form" class="col-md-8 col-md-offset-2">
    @if($post->exists)
        <form action="{{ route('update_post_path', ['post' => $post->id]) }}" method="POST">
            {{ method_field('PUT') }}
    @else
        <form action="{{ route('store_post_path') }}" method="POST">
    @endif

        {{ csrf_field() }}

        <div class="form-group">
            <label for="title">Titel:</label>
            <input type="text" name="title" class="form-control" value="{{ $post->title or old('title') }}"/>
        </div>

        <div class="form-group">
            <label for="description">Beschrijving:</label>
            <textarea rows="5" name="description" class="form-control"/>{{ $post->description or old('description') }}</textarea>

        </div>

        <div class="confirmButtons">
            @if($post->exists)
                <div class="form-group">
                    <button type="submit" class='btn btn-success'>Post bewerken</button>
                </div>
            @else
                <div class="form-group">
                    <button type="submit" class='btn btn-success'>Post toevoegen</button>
                </div>
            @endif
            <div class="form-group">
                <a href='javascript:history.back()' class='btn btn-primary'>Annuleren</a>
            </div>
        </div>
    </form>
    <div class="form-group">
        @if($post->wasCreatedBy( Auth::user() ))
            <small class="pull-right">
                <form action="{{ route('delete_post_path', ['post' => $post->id]) }}" method="POST">
                    {{ csrf_field() }}
                    {{ method_field('DELETE') }}
                    <button type="submit" class="btn btn-danger">Verwijderen</button>
                </form>
            </small>
        @endif
    </div>
</div>