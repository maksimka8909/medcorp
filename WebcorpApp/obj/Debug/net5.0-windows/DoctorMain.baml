   M S B A M L   `   `   `  ����E  AWebcorpApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WebcorpApp
WebcorpApp  5   	       WebcorpApp.DoctorMain   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WebcorpApp     5   	   -   5          � Title$  Доктор��5   	   $	��450��6   $	��800��6(   $	��450��67   $	��800��6D    � WindowStyle$ ThreeDBorderWindow=�6P    � WindowState$ 	Maximized=�6q   .��5	      �  � RowDefinitions 5
   
   �� 5      $��35 �6   �� 5      $��* �6   .+�5   
   � ���	#FF73D7AC$��0��6&   $��0 0 0 1q�63   .+�5      �� $��/Images/Logo2.png��6   $
��Left=�6/   $��Center=�6J   $	��100��6e   $��25��6q   $��10 0 0 0q�6}   5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5      $��* �6#   .+�5      � ���	#FF73D7AC$��0��6*   .+�5      �� -   5         ��Name$ cbContentType��5      $��Center=�62   $	��Top=�6O   $	��160��6g   $��0 20 0 0q�6s   $��Segoe UI Semibold)�6�   $��18(�5      6)   �� 5      $��5��6   $��Bottom=�6*   $��Center=�6E   $	��100��6b   $��0 0 0 30q�6n   .+�5      �� -   5        $��btnExit��5      $��
Назад��6-   $��Stretch=�6=   $��Center=�6[   $��30��6v   $��18(�6�   $y�Visible=�6�   ���	#FF77D8AF
�������
�������$��Segoe UI Semibold)�5    [    � 	Resources 5!       �� 
TargetType �� Property	 �� Value��%^   '��       �� 5"      " ��6$   .�5#   "   ��  �@��CornerRadius$	 5��6A   5$      5%      5&      �� 5(      -   5        $��btnClose��5(      $��
Выход��6.   $��Stretch=�6>   $��Center=�6\   $��30��6w   $��18(�6�   $y�Visible=�6�   ���	#FF77D8AF
�������
�������$��Segoe UI Semibold)�5)   [   $��0,5,0,0q�6z    5*      ��%^   '��       �� 5+      " ��6$   .�5,   "   ��  �@��CornerRadius$	 5��6A   5-      5.      5/      50      51      � 54      -   5        
 �Name$
 contentRecords��54      $��1��6+   $y�Visible=�6;   .+�55      &   System.Windows.Controls.DataGrid  -   5        $��	dgRecords��55         CanUserAddRows$ False��6,      CanUserDeleteRows$ False��6C      CanUserReorderColumns$ False��6]      
IsReadOnly$
 True��6{      SelectionMode$ Single=�6�    � ContextMenu 57      �� 58      .@�59      m� -   5         m�Name$ cmRecordsCheck��59   '   $#��Провести осмотр��6?   ${�False��6X   6j   5:         Columns 5<      0  *System.Windows.Controls.DataGridTextColumn  5=      ,  &System.Windows.Controls.DataGridColumn   Header$ Записи��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6=   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   ��  �� Path$
 name�5?      5@      � 5C      -   5        $
 contentCheckup��5C      $��1��6+   $y�	Collapsed=�6;   .+�5D        -	   5        $��	dgCheckup��5D      $ False��6,   $ False��6C   $ False��6]   $
 True��6{   $ Single=�6�    5E        5F      $ Осмотры��6-   $ * 6>    6H   �� $
 name�5H      5I      5J      5K      5L      