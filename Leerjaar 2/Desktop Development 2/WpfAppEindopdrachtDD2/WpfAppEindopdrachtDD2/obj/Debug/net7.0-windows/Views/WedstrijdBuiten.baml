   M S B A M L   `   `   `  ????P  LWpfAppEindopdrachtDD2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:WpfAppEindopdrachtDD2.ViewsWpfAppEindopdrachtDD2.Views  5   	   1    +WpfAppEindopdrachtDD2.Views.WedstrijdBuiten   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:WpfAppEindopdrachtDD2.Views     5   	     ? Title$  WedstrijdBuiten??5   	   $	??450??6!   $	??800??6.   .??5	      ? .+?5
   
   ?? $??Center=?6   $??Center=?62   .+?5      ?? $??25(?6   $
??bold"?6&    ?? Padding$ 	20,0,20,0q?68   
????? ?
???   ?6s   ?? 5       ?? Orientation$ 
Horizontal=?6   .+?5      ?? $??15(?6   $??60??6*    ?? TextAlignment$ Center=?65   Naam6R   ?? 5      $	??250??6    ? DataContext 6&   ?? *Buitenwedstrijd+??6N   ?? *Naam+6f   5      ?? 5      $ 
Horizontal=?6   .+?5      ?? $??15(?6   $??90??6*   $ Center=?65   
Startdatum6X   (  "System.Windows.Controls.DatePicker  5      $	??220??6    6)   ?? *Buitenwedstrijd+   SelectedDate 6Q   ?? *
StartDatum+6w   5      ?? 5      $ 
Horizontal=?6   .+?5      ?? $??15(?6   $??90??6*   $ Center=?65   
Doorstroom6X   	? 5      -   5         	?Name$ rbDoorstroomT??5      $??30,3,0,0q?65   .??6G   Ja6K   	? 5      -   5        $ rbDoorstroomF??5   /    d? 	IsChecked$
 TrueY?6   $??10,3,0,0q?6F   .??6X   Nee6]   5      ?? 5      $ 
Horizontal=?6   .+?5      ?? $??15(?6   $??50??6*   $ Center=?65   Duur6R   ?? 5      $??15(?6X   $??90,0,0,0q?6f    6   ?? *Buitenwedstrijd+??6B   ?? *Duur+6z   ?? 5      -   5         ??Name$ btnAdd10??5      $??15(?6+   
???????$??10,0,0,0q?6Q   .??6z   106~   ?? 5      -   5        $ btnAdd1??5      $??15(?6*   
???????.??6f   ^6i   ?? 5      -   5        $ btnSubtract1??5      $??15(?6/   
???  ??	 J? RenderTransformOrigin$	 0.5,0.5&?6N   z?5      V? 5       .~?5!      ?? ?? 5"      ?? 5#      
 ?? Angle$	
 180Q?6.   T? 5$      5%      .??5&   .   ^5'      ?? 5(      -   5        $ btnSubtract10??5(      $??15(?60   
???  ??$	 0.5,0.5&?6O   .??6?   106?   5)      ?? 5*      -   5        $ 	btnCreate??5*      .??6@   
Aanmaken6J   5+      5,      5-      