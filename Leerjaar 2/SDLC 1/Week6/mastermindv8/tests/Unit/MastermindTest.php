<?php

namespace Tests\Unit;

use PHPUnit\Framework\TestCase;
use App\Models\MM;

class MastermindTest extends TestCase
{
    /**
     * A basic unit test example.
     *
     * @return void
     */
    public function testNieuwSpel()
    {
        $mm = new MM();
        $mm->TeRaden = "0000";
        $mm->NieuwSpel();
        $this->assertNotEquals("0000", $mm->TeRaden, "Fout");
    }

    public function testNieuweBeurt()
    {
        $mm = new MM();
        $oudebeurt = $mm->Beurt;
        $mm->NieuweBeurt();
        $nieuwebeurt = $mm->Beurt;

        if($oudebeurt + 1 == $nieuwebeurt)
        {
            $this->assertTrue(true);
        }
        else
        {
            $this->assertTrue(false);
        }
    }

    public function testPositiesOK()
    {
        $mm = new MM;
        $mm->TeRaden = "1234";
        $aantal = $mm->PositiesOK("0253");
        $this->assertEquals(1, $aantal, "PositiesOK fout");
    }

    public function testAantalOK()
    {
        $mm = new MM;
        $mm->TeRaden = "1234";
        $aantal = $mm->AantalOK("0253");
        $this->assertEquals(2, $aantal, "AantalOK fout");
    }

    public function testAantal()
    {
        $mm = new MM;
        $mm->TeRaden = "1234";
        $aantal = $mm->AantalOK("0253");
        $this->assertEquals(2, $aantal, "AantalOK fout");
    }
    public function testAantal2()
    {
        $mm = new MM;
        $mm->TeRaden = "2234";
        $aantal = $mm->AantalOK("0253");
        $this->assertEquals(2, $aantal, "AantalOK2 fout");
    }
    public function testAantal3()
    {
        $mm = new MM;
        $mm->TeRaden = "1234";
        $aantal = $mm->AantalOK("2253");
        $this->assertEquals(2, $aantal, "AantalOK3 fout");
    }


}
