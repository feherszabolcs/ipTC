   M S B A M L   `   `   `  ����R  NIP-TranslatorCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:IP_TranslatorCalculatorIP_TranslatorCalculator  5   	   (    "IP_TranslatorCalculator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:IP_TranslatorCalculator     5   	     � Title$  IP-számoló��5   	   $	��900��6   $
��1600��6)    � 
ResizeMode$ CanResizeWithGrip=�66    � WindowStartupLocation$ CenterScreen=�6U   $	��900��6z   $
��1600��6�   .��5	      � -   5         �Name$ GrMain��5	      .+�5
   
   ��  �� Orientation$ 
Horizontal=�6   $��60��6.   $	��Top=�6:   
�������.+�5      �� -   5         ��Name$ BtnTranslate��5   B      RoundButtonTemplate#��[  6   $��IP-v4 átváltó��6X   $	��450��6p   $��36(�6|   $
��Bold"�6�   $��	75,0,50,0q�6�   6�   �� 5      -   5        $ BtnOptimizer��5   B   #��[  6   $��Hálózat optimalizáló��6X   $	��450��6w   $��36(�6�   $
��Bold"�6�   $��0,0,50,0q�6�   6�   �� 5      -   5        $ BtnNwAddress��5   C   #��[  6   $!��Hálozati cím számítása��6Y   $	��450��6z   $��36(�6�   $
��Bold"�6�   $��0,0,75,0q�6�   6�   5      �� 5   
   $��0��6   $��Bottom=�6%   .+�5      �� -   5        $ BtnHome��5      $��50��6&   $��Right=�61   $��	0,0,20,20q�6M   .��5      �� .+�5      �� $��/PngItem_2619202.png��6   6<   5      5      5       � 5   
   -   5          �Name$
 Main��5      $��0,60,0,0q�6     � NavigationUIVisibility$ Hidden=�60   5      5      