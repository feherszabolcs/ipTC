   M S B A M L   `   `   `  ����R  NIP-TranslatorCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:IP_TranslatorCalculatorIP_TranslatorCalculator  5      )    #IP_TranslatorCalculator.IPTranslate   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:IP_TranslatorCalculator     5      -   5          N� Title$  IPTranslate��5	      .��5      � 
�������$��0,0,0,0q�6   .+�5   
    � -   5          �Name$
 Main��5      $��	0,120,0,0q�6     � NavigationUIVisibility$ Hidden=�61   �� 5   
   -   5        $	��tb1��5   �   $��100,0,0,423q�6   $��80��6'   $
��Left=�63   $	��300��6N   $��Bottom=�6Z   $��34(�6u   $
��Bold"�6�   $y�Hidden=�6�    �� 	MaxLength$ 3��6�   �� 5   
   -   5        $	��tb2��5   �   $��461,0,0,423q�6   $��80��6'   $��Bottom=�63   $
��Left=�6N   $	��300��6i   $��34(�6u   $
��Bold"�6�   $y�Hidden=�6�   $ 3��6�   �� 5   
   -   5        $	��tb3��5   �   $	��300��6   $
��Left=�6   $��830,0,0,423q�69   $��80��6N   $��Bottom=�6Z   $��34(�6u   $
��Bold"�6�   $y�Hidden=�6�   $ 3��6�   �� 5   
   -   5        $	��tb4��5   �   $	��300��6   $
��Left=�6   $��1200,0,0,423q�69   $��80��6O   $��Bottom=�6[   $��34(�6v   $
��Bold"�6�   $y�Hidden=�6�   $ 3��6�   �� 5   
   -   5         ��Name$ ChbDec��5      $��
Decimális��6#   $��0,0,1240,537q�67   $��Bottom=�6M   $��36��6h   $��24(�6t   $��Right=�6�   $	��220��6�   $
��Bold"�6�   �� 5   
   -   5        $ ChbBin��5      $��Bináris��6#   $��Right=�65   $��0,0,1182,537q�6Q   $��Bottom=�6g   $��36��6�   $��24(�6�   $
��Bold"�6�   6�   �� 5   
   -	   5         ��Name$ 	TbBinform��5      $��Right=�6%   $��0,0,839,423q�6A   $y�Hidden=�6V    �� TextWrapping$
 Wrap=�6�   $��Bottom=�6�   $	��621��6�   $��80��6�   $��34(�6�   $ 32��6�   $��Normal"�6�   �� 5   
   $��0��6   $��Bottom=�6%   .+�5      �� -
   5         ��Name$ BtnHome��5      $��50��6&   $��Right=�61   $��	0,0,20,20q�6M   .��5      �� .+�5      �� $��/PngItem_2619202.png��6   6<   5      5      5      �� 5   
   -   5        $��btnTranslate��5   $   $��
Fordítás��6   $��Right=�68   $��0,0,1347,346q�6T   $��Bottom=�6j   $��44��6�   $	��113��6�   6�   �� 5   
   -   5        $��tbOutput��5   .   $��Right=�6    �� 
IsReadOnly$
 True��6>   $��0,0,839,144q�6P   $y�Hidden=�6e   $
 Wrap=�6y   $��Bottom=�6�   $��80��6�   $	��621��6�   $��34(�6�   �� 5   
   -   5        $��lblOut��5   �   $�� ��6   $��Right=�6   $��0,0,913,229q�67   $��Bottom=�6L   $	��547��6g   $��20(�6s   $��49��6�   6�   5      5      