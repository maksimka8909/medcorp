   M S B A M L   `   `   `  ����E  AWebcorpApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WebcorpApp
WebcorpApp  5   	       WebcorpApp.SupplyWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WebcorpApp     5   	   -   5          � Title$  Поставки��5   	   $	��450��6   $	��750��6*   $	��450��69   $	��750��6F    � WindowStyle$ ThreeDBorderWindow=�6R    � WindowStartupLocation$ CenterScreen=�6s   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   � $��0��6   ���	#FF73D7AC.+�5      �� $��/Images/Logo2.png��6   $��50��6/   5      � 5   
   $��1��6   $��Center=�6   $��Center=�67    5      �� 5      $��* �6    �� 5      $
��auto �6    .+�5      � $��0��6   $��0 0 0 10q�6     � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� $��0��6   $��Center=�6-   $��Center=�6H   $	��200��6e   .+�5       	� -   5         	�Name$ rbEquipment��5    "   $��Оборудования��67    d� 	IsChecked$
 TrueY�6N   $��Segoe UI Semibold)�6_   $��18(�6~   6�   	� 5!      -   5        $ rbDrug��5!   "   $��Препараты��62   $��Segoe UI Semibold)�6F   $��18(�6e   6s   �� 5"      -   5         ��Name$ cbEquipment��5"      $y�Visible=�64   $��Segoe UI Semibold)�6I   $��18(�6h   �� 5#      -   5        $ cbDrug��5#      $y�	Collapsed=�6/   $��Segoe UI Semibold)�6F   $��18(�6e   �� 5$      $��Количество��6    $��Segoe UI Semibold)�62   $��18(�6Q   $��0 10 0 0q�6_   �� 5%      -   5         ��Name$ 
tbQuantity��5%      $��Segoe UI Semibold)�62   $��18(�6Q   �� 5'      -   5        $��btnAdd��5'      $��Добавить��6,   $��Center=�6?   $��Center=�6\   $��30��6w   $��18(�6�   $y�Visible=�6�   ���	#FF77D8AF
�������
�������$��Segoe UI Semibold)�5(   [   $��0��6�   $	��100��5)      $	��0 7q�6%   	 � 	Resources	 5*      
 �� 
TargetType �� Property �� Value��%^   '��       �� 5+      "
 ��6$   .�5,   "   ��  �@��CornerRadius$ 5��6A   5-      5.      5/      50      &   System.Windows.Controls.DataGrid  52      -   5        $��dgEquipment��52         CanUserAddRows$ False��6.      CanUserDeleteRows$ False��6E      CanUserReorderColumns$ False��6_      
IsReadOnly$
 True��6}      SelectionMode$ Single=�53      $��1��6c   $��10q�6s   $	��200��6   $y�Visible=�6�    � ContextMenu 54      �� 55      .@�56      m� -	   5         m�Name$ cmEquipmentDelete��56   '   $��Удалить��6B   ${�False��6S   6e   57         Columns 59      0  *System.Windows.Controls.DataGridTextColumn  5:      ,  &System.Windows.Controls.DataGridColumn   Header$ Оборудование��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6C   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6M   ��  �� Path$
 name�5<        5>      -
   5        $��dgDrugs��5>      $ False��6*   $ False��6A   $ False��6[   $
 True��6y   $ Single=�5?      $��1��6_   $��10q�6o   $	��200��6{   $y�	Collapsed=�6�    5@      �� 5A      .@�5B      m� -   5        $ cmDrugDelete��5B   '   $��Удалить��6=   ${�False��6N   6`   5C       5E        5F      $ Препараты��6-   $ * 6@    6J   �� $
 name�5H      5I      � 5K      $��1��6   $��Center=�6    $��Center=�6=    5L      �� 5M      �� 5N      .+�5Q      �� -   5        $��	btnCancel��5Q      $��
Назад��6+   $��Center=�6;   $��Center=�6X   $��30��6s   $��18(�6   $y�Visible=�6�   ���	#FF77D8AF
�������
�������$��Segoe UI Semibold)�5R   [   $��0��6�   $	��100��5S      $	��5 0q�6%   	 5T      ��%^   '��       �� 5U      "
 ��6    .�5V      ��  �@��CornerRadius$ 5��6=   5W      5X      5Y      �� 5[      -   5        $��
btnConfirm��5[      $��Сохранить��6,   $��Center=�6@   $��Center=�6]   $��30��6x   $��18(�6�   $y�Visible=�6�   ���	#FF77D8AF
�������
�������$��Segoe UI Semibold)�5\   [   $��1��6�   $	��100��5]      $	��5 0q�6%   	 5^      ��%^   '��       �� 5_      "
 ��6    .�5`      ��  �@��CornerRadius$ 5��6=   5a      5b      5c      5d      5e      5f      5g      