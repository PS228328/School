<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Bankrekening;

class BankrekeningController extends Controller
{
    public function index()
    {
        $rekening = new Bankrekening(0.00);
         session(['saldo' => $rekening->GetSaldo()]);
         session(['bevroren' => false]);
        return view('bankrekening',
                               array('saldo'=>$rekening->GetSaldo(), 'bevroren'=>$rekening->bevroren));
    }
    public function bevroren()
    {
        $rekening = new Bankrekening(session('saldo'));
        $rekening->bevroren = !session('bevroren');
        session(['saldo' => $rekening->GetSaldo()]);
        session(['bevroren' => $rekening->bevroren]);
        return view('bankrekening',
                               array('saldo'=>$rekening->GetSaldo(), 'bevroren'=>$rekening->bevroren));
    }
    public function opnemen(Request $request)
    {
        $rekening = new Bankrekening(session('saldo'));
        $rekening->bevroren = session('bevroren');
        $amount = $request->input('bedrag');
        $rekening->Opnemen($amount);
        session(['saldo' => $rekening->GetSaldo()]);
        session(['bevroren' => $rekening->bevroren]);
        return view('bankrekening',
                               array('saldo'=>$rekening->GetSaldo(), 'bevroren'=>$rekening->bevroren));
    }
    public function storten(Request $request)
    {
        $rekening = new Bankrekening(session('saldo'));
        $rekening->bevroren = session('bevroren');
        $amount = $request->input('amount');
        $rekening->Storten($amount);
        session(['saldo' => $rekening->GetSaldo()]);
        session(['bevroren' => $rekening->bevroren]);
        return view('bankrekening',
                               array('saldo'=>$rekening->GetSaldo(), 'bevroren'=>$rekening->bevroren));
    }
}

