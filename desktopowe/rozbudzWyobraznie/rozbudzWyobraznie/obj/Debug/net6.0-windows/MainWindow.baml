   M S B A M L   `   `   `  ????L  HrozbudzWyobraznie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:rozbudzWyobraznierozbudzWyobraznie  5   	   "    rozbudzWyobraznie.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:rozbudzWyobraznie     5   	     ? Title$  Notatnik??5   	   $	??450??6   $	??800??6'   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??1* ?6   ?? 5      $??2* ?6   ?? 5      $??1* ?6    ? ColumnDefinitions 5   
   ?? 5      $??1* ?6   ?? 5      $??1* ?6   .+?5   
   ?? $??Zapis notatek??6   $??Center=?6(   ?? 5   
   -   5         ??Name$ saveNoteTextBox??5   [   $??2??6   $??10,30,10,10q?6#   " ?? VerticalScrollBarVisibility$
 Auto=?68    ?? TextWrapping$
 Wrap=?6t   ?? 5   
   $??2??6   $??1??6!   $??Odczyt notatek??61   $??Center=?6J   ?? 5   
   -   5        $ readNoteTextBox??5   k   $??2??6   $??1??6#   $??10,30,10,10q?63   $
 Auto=?6H   $
 Wrap=?6?   ?? 5   
    ?? Orientation$ 
Horizontal=?6   $??2??6.   $??2??6;   $??Center=?6O   $??Center=?6j   .+?5      ?? -   5        $??Zapisz notatkę??5      $??20(?6.   $??20q?6<   6I   ?? 5      -   5        $!??Odczytaj ostatnią notatkę??5      $??20(?69   $??20q?6G   6T   ?? 5      -   5        $??Usuń ostatnią notatkę??5      $??20(?65   $??20q?6C   6P   5      5      5      