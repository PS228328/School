   M S B A M L   `   `   `  ????J  FWpf_prg2_timers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Wpf_prg2_timersWpf_prg2_timers  5   	       Wpf_prg2_timers.Bartender   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Wpf_prg2_timers     5   	     ? Title$  	Bartender??5   	    ? WindowState$ 	Maximized=?6    ? 
ResizeMode$ NoResize=?63   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??1* ?6   ?? 5      $	??10* ?6   ?? 5      $??2* ?6   .+?5   
   ]? $??0??6   
?????????.  .+?5      ?? $??Score: ??6   
????  ?$??20(?69   $
??Left=?6G   ?? 5      -   5         ??Name$ tblScore??5      
????  ?$??20(?6<   $??0??6J   $
??Left=?6S   ?? 5      -   5        $ tblUser??5      
????  ?$??20(?6;   $
??Gast??6I   $??Right=?6U   ?? 5      -   5        $ failures??5      $
??Bold"?6*   
???  ??$??20(?6M   $??30??6[   $??	200,0,0,0q?6e   $	??Top=?6x   ?? 5      $??Welkom: ??6   
????  ?$??20(?6:   $??Right=?6H   5      ? 5   
   -   5         ?Name$ 
grGameGrid??5      $??1??6#   ??5      ?? 5       ?? ImageSource$ Resources/cafe5.jpg??6   .+?5      ?? -   5         ??Name$ 	imgWaiter??5      $
??Fill=?6'   $
??Left=?66   $??Bottom=?6Q   $??70,0,0,0q?6l   $	??200??6~   $	??200??6?   $ ??Resources/oktoberfest1.png??6?   5      ? 5   
   $??2??6   ??5      ?? 5      $ Resources/vloerA2.jpg??6    j? Stretch$ UniformToFill=?6A   5!      5"      5#      