   M S B A M L   `   `   `  ????D  @Lj2Dd1En2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Lj2Dd1En2	Lj2Dd1En2  5   	       Lj2Dd1En2.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Lj2Dd1En2     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ? .+?5
   
   ?  ? ColumnDefinitions 5      ?? 5      ?? 5      .+?5      ? $??0??6    ? RowDefinitions 5      ?? 5      $
??Auto ?6$   ?? 5      .+?5      ?? $??Autos??6   $??0??5      $??20(?5      $??Black"?6&    ?? TextAlignment$ Center=?69   ?? 5      -   5         ??Name$ LbAutos??5      $??1??6,    ?? DisplayMemberPath$
 make??5       ?? SelectedValuePath$ carId??5      5      ? 5      $??1??6   $??
2, 0, 0, 2q?6#    5       ?? 5!      ?? 5"      .+?5$      ? $??0??6   
??????? 5%      ?? 5&      $
??Auto ?6+   ?? 5'       5)      ?? 5*      $
??Auto ?6(   ?? 5+      $
??Auto ?6(   ?? 5,      ?? 5-      $
??Auto ?6(   ?? 5.      $
??Auto ?6(   ?? 5/      $
??Auto ?6(   .+?51      ?? $??0??6    $??0??6-   $??2??6=   $??SelectedAuto??6Q   $??20(?52       $??Black"?6.   $ Center=?6A   ?? 53      $??1??6    $??0??6-   $
??Merk??6=   ?? 54      -   5         ??Name$ tbauto??54   =   $??1??6    $??1??6-   6=   ?? 55      $??2??6    $??0??6-   $??
Afbeelding??6=   ?? 56      -   5         ??Name$ imgAfbeelding1??56   =   $??2??6    $??1??6-   6=   ?? 57      -   5        $??3??57       $??1??6-   $??afbeelding...??6=   6V   ?? 58      $??4??6    $??0??6-   $
??Jaar??6=   ?? 59      -   5        $ TbJaar??59   =   $??4??6    $??1??6-   6=   ?? 5:      $??5??6!   $??1??6.   	 ?? Orientation$	 
Horizontal=?6>   .+?5;      ?? -   5        $??Update??5;   !   $??5q?6J   ?? 5<      -   5        $??Delete??5<   !   $??5q?6J   5=      5>      ? 5@      $??1??6   
??????? 5A      ?? 5B      $
??Auto ?6+   ?? 5C       5E      ?? 5F      $
??Auto ?6(   ?? 5G      $
??Auto ?6(   ?? 5H      ?? 5I      $
??Auto ?6(   ?? 5J      $
??Auto ?6(   ?? 5K      $
??Auto ?6(   .+?5N      ?? $??0??6    $??0??6-   $??2??6=   $??NewAuto??6Q   $??20(?5O       $??Black"?6.   $ Center=?6A   ?? 5P      $??1??6    $??0??6-   $
??Merk??6=   ?? 5Q      -   5        $ TbMerk2??5Q   =   $??1??6    $??1??6-   6=   ?? 5R      $??2??6    $??0??6-   $??
Afbeelding??6=   ?? 5S      -	   5        $ imgAfbeelding2??5S   =   $??2??6    $??1??6-   6=   ?? 5T      -
   5        $??3??5T       $??1??6-   $??afbeelding...??6=   6V   ?? 5U      $??4??6    $??0??6-   $
??Jaar??6=   ?? 5V      -   5        $ TbJaar1??5V   =   $??4??6    $??1??6-   6=   ?? 5W      -   5        $??5??5W       $??1??6-   $??Create??6=   $??5q?6N   6Y   5X      5Y      5Z      5[      5\      