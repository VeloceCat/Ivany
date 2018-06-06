@if(session()->has('danger'))

    <div class="alert alert-danger">
        {{ session()->get('danger') }}
    </div>

@endif