   M S B A M L   `   `   `  ????L  HVerkeerskruispunt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:VerkeerskruispuntVerkeerskruispunt  5   	   "    Verkeerskruispunt.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Verkeerskruispunt     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)    ? 
ResizeMode$ CanMinimize=?65   .??5	      ? -   5         ?Name$ 
grjunction??5	       ? RowDefinitions 5
   
   ?? 5      $??* ?6   6)   ?? 5      $??72 ?6   6*   ?? 5      $??72 ?6   6*   ?? 5      $??* ?6   6)    ? ColumnDefinitions 5   
   ?? 5      $??* ?6   6+   ?? 5      $??6 ?6   6+   ?? 5      $	??100 ?6   6-   ?? 5      $	??100 ?6   6-   ?? 5      $??* ?6   6+   ??5   
   ?? 5       ?? ImageSource$ Assets/IMG_E3387.JPG??6   6>   .+?5   
   ? -   5        $ 	spawnLeft??5      $??2??6"   $??0??6/   6A   ? 5   
   -   5        $ 
spawnRight??5      $??1??6#   $??4??60   6B   ? 5   
   -   5        $ spawnTop??5      $??0??6!   $??2??6.   6@   ? 5   
   -   5        $ spawnBottom??5      $??3??6$   $??3??61   6C   ?? 5   
   -   5         ??Name$ myButton??5      $??Bottom=?6#   $??Right=?6>   $??	0,0,50,50q?6Z   $	??100??6m   $??50??6y   $??Start!??6?   $??20(?6?   $
??Bold"?6?   6?   5      5       