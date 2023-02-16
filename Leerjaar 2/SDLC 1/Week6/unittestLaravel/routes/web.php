<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\BankrekeningController;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', [BankrekeningController::class, 'index']);
Route::post('bevroren', [BankrekeningController::class, 'bevroren']);
Route::post('opnemen',  [BankrekeningController::class, 'opnemen']);
Route::post('storten', [BankrekeningController::class, 'storten']);

