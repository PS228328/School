<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Hash;

class WachtwoordController extends Controller
{
    public function nieuw(Request $request){
        $wachtwoord = $request->password;
        $hash = Hash::make($wachtwoord);
        session(['hash' => $hash]);
        return view('home2',
            ['hash' => session('hash', '?'), 'correct' => true, 'wachtwoord' => $wachtwoord]);
    }

    public function index(Request $request){
        $wachtwoord = $request->passwordCheck;
        $hash = Hash::make($wachtwoord);
        $correct = Hash::check($wachtwoord, session('hash', '?'));
        return view('home3',
            ['hash' => session('hash', '?'), 'correct' => $correct]);
    }

}
