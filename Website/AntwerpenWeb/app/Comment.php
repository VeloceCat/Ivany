<?php

namespace App;

use App\Post;
use App\User;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Database\Eloquent\SoftDeletes;

class Comment extends Model
{
    use SoftDeletes;

    protected $table = 'comments';

    protected $casts = ['user_id' => 'integer', 'post_id' => 'integer'];

    protected $fillable = ['comment'];

    protected $dates = ['deleted_at'];

    public function post() {
        return $this->belongsTo(Post::class);
    }
    
    public function user() {
        return $this->belongsTo(User::class);
    }

    public function wasCreatedBy($user) {

        if( is_null($user) ) {
            return false;
        }

        return $this->user_id === $user->id;
    }
}
