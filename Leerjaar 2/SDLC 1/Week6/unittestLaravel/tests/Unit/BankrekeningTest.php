<?php

namespace Tests\Unit;

use PHPUnit\Framework\TestCase;
use App\Models\Bankrekening;

class BankrekeningTest extends TestCase
{
    public function test_Storten_Geldig_Bedrag()
    {
        $rekening = new Bankrekening(11.99);                			// Arrange
        $rekening->Storten(4.55);                                              // Act
        $this->assertEqualsWithDelta(16.54, $rekening->GetSaldo(), 0.001,
               "storten niet gelukt"); 						// Assert
    }
    public function test_Opnemen_Geldig_Bedrag()
    {
        $rekening = new Bankrekening(11.99);                			// Arrange
        $rekening->Opnemen(4.55);                                               // Act
        $this->assertEqualsWithDelta(7.44, $rekening->GetSaldo(), 0.001,
               "opnemen niet gelukt "); 						// Assert
    }
    public function test_Storten_Negatief()
    {
        $rekening = new Bankrekening(11.99);                				// Arrange
        $rekening->Storten(-4.55);                                                 // Act
        $this->assertEqualsWithDelta(11.99, $rekening->GetSaldo(), 0.001,
               " Negatieve waarde in storting"); 					// Assert
    }
    public function test_Opnemen_negatief()
    {
        $rekening = new Bankrekening(11.99);                				// Arrange
        $rekening->Opnemen(-4.55);                                                 // Act
        $this->assertEqualsWithDelta(11.99, $rekening->GetSaldo(), 0.001,
                " Negatieve waarde in opname ");  					// Assert
    }
    public function test_Storten_Bevroren_Rekening()
    {
        $rekening = new Bankrekening(11.99);
        $rekening->bevroren = true;            			// Arrange
        $rekening->Storten(4.55);                                              // Act
        $this->assertEqualsWithDelta(16.54, $rekening->GetSaldo(), 0.001,
               "storten niet gelukt");
    }
    public function test_Opnemen_Bevroren_Rekening()
    {
        $rekening = new Bankrekening(11.99);
        $rekening->bevroren = true;           				// Arrange
        $rekening->Opnemen(4.55);                                                 // Act
        $this->assertEqualsWithDelta(11.99, $rekening->GetSaldo(), 0.001,
                " Het is toch wel opgenomen ");
    }


}
