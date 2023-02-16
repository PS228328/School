<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Bankrekening extends Model
{
    private float $saldo = 0.0;
    public function GetSaldo() : float
    {
         return $this->saldo;
    }
    public bool $bevroren = false;
    public function __construct($amount)
    {
        $this->saldo = $amount;
    }

    public function Opnemen (float $amount) : void
    {
        if ($this->bevroren) return;
        if($amount < 0) return;
        $this->saldo -= $amount;
    }
    public function Storten(float $amount) : void
    {
        if($amount < 0) return;
        $this->saldo += $amount;
    }
}
