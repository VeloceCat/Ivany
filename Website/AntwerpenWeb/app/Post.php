<?php

namespace App;

use App\User;
use App\Comment;
use App\Vote;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Support\Facades\Auth;
use Illuminate\Database\Eloquent\SoftDeletes;

class Post extends Model {
    use SoftDeletes;

    protected $table = 'posts';

    protected $casts = ['user_id' => 'integer'];

    protected $fillable = ['title', 'description', 'url'];

    protected $dates = ['deleted_at'];

    public function user() {
        return $this->belongsTo(User::class);
    }

    public function wasCreatedBy($user) {

        if( is_null($user) ) {
            return false;
        }

        return $this->user_id === $user->id;
    }

    public function comments() {
        return $this->hasMany(Comment::class);
    }

}