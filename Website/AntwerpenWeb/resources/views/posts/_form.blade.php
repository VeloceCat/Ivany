<div id="post-form" class="col-md-8 col-md-offset-2">
    @if($post->exists)

        <form action="{{ route('update_post_path', ['post' => $post->id]) }}" method="POST">
            {{ method_field('PUT') }}

    @else

        <form action="{{ route('store_post_path') }}" method="POST">

    @endif

        {{ csrf_field() }}

        <div class="form-group">

            <label for="title">Title:</label>
            <input type="text" name="title" class="form-control" value="{{ $post->title or old('title') }}"/>
        </div>


        <div class="form-group">

            <label for="description">Description:</label>
            <textarea rows="5" name="description" class="form-control"/>{{ $post->description or old('description') }}</textarea>

        </div>

        <div class="form-group">

            <label for="url">Url:</label>
            <input type="text" name="url" class="form-control" value="{{ $post->url or old('url') }}"/>

        </div>

        @if($post->exists)
            <div class="form-group">
                <button type="submit" class='btn btn-primary'>Edit Article</button>
            </div>
        @else
            <div class="form-group">
                <button type="submit" class='btn btn-primary'>Add Article</button>
            </div>
        @endif
    </form>
    <div class="form-group">
        @if($post->wasCreatedBy( Auth::user() ))
            <small class="pull-right">
                <form action="{{ route('delete_post_path', ['post' => $post->id]) }}" method="POST">
                    {{ csrf_field() }}
                    {{ method_field('DELETE') }}
                    <button type="submit" class="btn btn-danger">Delete</button>
                </form>
            </small>
        @endif
    </div>
</div>