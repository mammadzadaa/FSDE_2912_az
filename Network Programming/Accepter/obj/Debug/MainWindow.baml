   M S B A M L   `   `   `  ����C  ?Accepter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AccepterAccepter  5   	       Accepter.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Accepter     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��400��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��1.5* �6   �� 5      �� 5      �� 5      .+�5   
   �� $��30(�6   $��Center=�6   $��Center=�5      .��6-   Connected :5      ]� 5   
   $��1��6   .+�5      �� .��6   IP :6   �� 5      ��6   �� *Ip+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6^   5      ]� 5   
   $��2��6   .+�5      �� .��6   Port :6   �� 5      ��6   �� *Port+$ TwoWay=�$ PropertyChanged=�6_   5      �� 5   
   $��3��6=   $��10q�6J   ��6   �� *DisconnectButtonClicked+.��6W   
Disconnect6c   5      5      