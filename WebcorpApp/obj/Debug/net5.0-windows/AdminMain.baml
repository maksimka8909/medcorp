   M S B A M L   `   `   `  ����E  AWebcorpApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WebcorpApp
WebcorpApp  5   	   b ^PresentationFramework.Aero2, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes 5	          WebcorpApp.AdminMain   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WebcorpApp     5   	   ]themeKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2     5	      -   5          � Title$   Администратор��5   	   $	��450��6   $	��800��6/   $	��450��6>   $	��800��6K    � WindowStyle$ ThreeDBorderWindow=�6W    � WindowState$ 	Maximized=�5	   _    � 	Resources 5
         ToolBarButtonHover �� Color  ToolBarMenuBorder  ToolBarSubMenuBackground  ToolBarHorizontalBackground  ToolBarVerticalBackground  ToolBarGripper + 'ToolBarToggleButtonHorizontalBackground ) %ToolBarToggleButtonVerticalBackground  ToolBarMainPanelBorderStyle �� 
TargetType �� Property �� Value �� Triggers	 �� Binding
 �� Source �� Value 	 ToolBarThumbStyle �� 
TargetType �� Padding J� SnapsToDevicePixels j� TileMode j� ViewboxUnits j� Viewbox j� Viewport j� ViewportUnits L� Drawing � Brush � Geometry �� Triggers P� Property P� Value (
 $ToolBarHorizontalOverflowButtonStyle ��Name �� CornerRadius �� 
TargetName & "ToolBarVerticalOverflowButtonStyle  ToolBarStyle1 �Name d�Name �� 	ClickMode  c� HasOverflowItems! � FocusVisualStyle" d� 	IsChecked# �� Mode$ �� RelativeSource% �Name& � AllowsTransparency' � 	StaysOpen5  /Microsoft.Windows.Themes.SystemDropShadowChrome(  Name)   Color* �� ClearTypeHint+ b�Name-  'System.Windows.Input.KeyboardNavigation,   DirectionalNavigation-   TabNavigation. b� 	WrapWidth/   TabIndex0 n�Name1 ��Name2 a�Name3 K� IsItemsHost4 P� 
SourceName��%�  &	        &	 #     &	 F     &	 i     &	 �     &	 �     &	 �     &	 �     &	     &		     7  &	
 �    7  7   7   7  &	 �    7  7   7   7  &	     7  7 
 7  7  7  7 	 7  7  �� 5   
   $ 	#210080FF��65   �� 5   
   $ 	#FFB6BDC5��64   �� 5   
   $ 	#FFEEF5FD��6;   �� 5   
   $ 	#FFEEF5FD��6>   �� 5   
   $ 	#FFEEF5FD��6<   �� 5   
   $ 	#FF6D6D6D��61   �� 5   
   $ 	#FFEEF5FD��6J   �� 5   
   $ 	#FFEEF5FD��6H   �� 5   
   " ��64   .�5      ��  � ��$ 0,0,11,0q�6'   �� 5       �@��CornerRadius$ 3,3,3,3��6-    5      �� 5      	 6   �� #
 Zr� true6b   .a�5      ��  �@��CornerRadius$ 0,0,0,0��65   5      5      �� 5   
   " n�6*   .�5      ��  � �� 5      �� 5      " n�6&   .R�5       �� 
������ # z��6:   $
 True��6^   ._�5!      �� ��5"   "   L� 5#   &   $
 Tile=�63   $ Absolute=�6C   $ 0,0,4,4�6[   $ 0,0,4,4�6m   $ Absolute=�6�    5$   *   I� 5%   .   .��5&   2   � 
 �����+ ��@B @B �@B ��- ���- ��- ���- @B 	6P   � 5'   2   8   + ��        �    �� р� �� р�     	6j   5(   /   5*   '   5,      5-       5.      P� 5/       �@J�IsMouseOver$
 true��6=   . �50   "   ��  �@�Cursor$ SizeAll��6;   51      53      55      56      �� 57   
   " d�6=   .�58      ��  � ��8   6+   �� 59       � ��$ 0��6*   �� 5:       � ��$ 0��6)   �� 5;       � �� 5<      �� 5=      " d�6&   .R�5>      �� $ Bd��6!   #��z��6-   $ 0,3,3,0��6W   $
 true��6n   ._�5?      �� $��Right=�6%   $��7��6A   $��7,2,2,2q�6L   $
 true��6]   $��Bottom=�6x   $��6��6�   .+�5@   "   F� ����@B `� р�[ `� 	
�������6>   F� 5A   "   ����     � �@KL  � 	#��z��6>   F� 5B   "   "���� �  	= Ѡ.c  	= ��g5 ��j 	
�������6H   F� 5C   "   "�����^����- �`�S ��- Ѡ%& ��[ 	#��z��6I   5D      5E       5F      P� 5G       �@J�IsMouseOver$
 true��6=   . �5H   "   �� $ Bd��6?   8   � ��6O   5I      P� 5J       �@J�IsKeyboardFocused$
 true��6C   . �5K   "   �� $ Bd��6?   8   � ��6O   5L      P� 5M       � {�$ false��6;   . �5N   "   �� 8   � ��6?   5O      5Q      5S       5T      �� 5U      	 6   �� #
 Zr� true6b   .a�5V      ��  � ��# � ��63   5W      5Y      �� 5Z   
   " d�6;   .�5[      ��  � ��8   6+   �� 5\       � ��$ 0��6*   �� 5]       � ��$ 0��6)   �� 5^       � �� 5_      �� 5`      " d�6&   .R�5a      �� $ Bd��6!   #��z��6-   $ 0,0,3,3��6W   $
 true��6n   ._�5b      �� $��Right=�6%   $��6��6A   $��2,7,2,2q�6L   $
 true��6]   $��Bottom=�6x   $��7��6�   .+�5c   "   F� ����`� @B �`� ��[ 	
�������6>   F� 5d   "   ���� �     � � @KL 	#��z��6>   F� 5e   "   "�����g5  � ���j �g5 � 	= �.c 	
�������6J   F� 5f   "   "������- �^��р�[ �%& ���- `�S 	#��z��6I   5g      5h       5i      P� 5j       �@J�IsMouseOver$
 true��6=   . �5k   "   �� $ Bd��6?   8   � ��6O   5l      P� 5m       �@J�IsKeyboardFocused$
 true��6C   . �5n   "   �� $ Bd��6?   8   � ��6O   5o      P� 5p       � {�$ false��6;   . �5q   "   �� 8   � ��6?   5r      5t      5v       5w      �� 5x      	 6   �� #
 Zr� true6b   .a�5y      ��  � ��# � ��63   5z      5|      �� 5}   
   " c�6&   .�5~      ��  � ��8   6+   �� 5       � �� 5�      �� 5�      " c�6&   .R�5�      � $
 Grid��6   $��3,1,1,1q�6-   $
 true��6>   .+�5�      � $ OverflowGrid��6#   $��Right=�69   .+�5�   "   d� $ OverflowButton��6/   $ Press=�6G   #{�z  6u   8�� $y�Hidden=�6E  ! 6Y   Z� " 6�   �� *IsOverflowOpen+$# TwoWay=�$ �� *TemplatedParent+6E  � 5�   "   $% OverflowPopup��6(   $
& true��6?   $|�false��6Y   $��Bottom=�6�   #��� .�6�   $' false��6*  ��6k   �� *IsOverflowOpen+$ �� *TemplatedParent+.��5�   &     $
( Shdw��6C   $) Transparent��6Q   ._�5�   *   �� $ ToolBarSubMenuBorder��61   8�� $��1q�6�   8�� $* Enabled=�6�   ._�5�   .   b� $+ PART_ToolBarOverflowPanel��6C   $, Cycle=�6f   $
|�true��6�   $��2q�6�   # z 6�   $- Cycle=�6  $	. 200Q�64  ! 6�   Z� 64  5�   +   5�   '   5�   #   5�      �� 5�      $ MainPanelBorder��6%   #��z��6>   #��z��6h   #��z��6�   # z��6�   8�� ._�5�   "   ]� $- Local=�6,   $/ 1��6U   .+�5�   &   n� $0 ToolBarThumb��6,   $��	-3,-1,0,0q�6B   $��6,5,1,6q�6U   8�� $��10��6�   �� 5�   &   $1 ToolBarHeader��67   $��Header��6N   $��Center=�6e   $��4,0,4,0q�6�   # z 6�   $��Center=�6�   a� 5�   &   $2 PART_ToolBarPanel��63   $
3 true��6N   $��0,1,2,2q�6a   # z 6r   5�   #   5�      5�       5�      P� 5�       �@c�IsOverflowOpen$
 true��6@   . �5�   "   �� $ ToolBarThumb��6>    � {�$ false��6X   5�      P� 5�       68   Z�  � ��. �5�   "   �� $ ToolBarHeader��6?    � y�$ 	Collapsed=�6Z   5�      P� 5�       �@`�IsLocked$
 true��6F   . �5�   "   �� $ ToolBarThumb��6?    � y�$ 	Collapsed=�6Y   5�      P� 5�      $4 OverflowPopup��6?    �@�HasDropShadow$
 true��6Z   . �5�   "   �� $
 Shdw��6;    � ��$ 0,0,5,5q�6M   �� 5�   "   $
 Shdw��6H    �@J�SnapsToDevicePixels$
 true��6Z   �� 5�   "   $
 Shdw��6:    �@ Color$ 	#71000000��6L   5�      P� 5�       �@c�Orientation$ Vertical=�6=   . �5�   "   �� $
 Grid��6;    � ��$ 1,3,1,1q�6M   �� 5�   "   $ OverflowButton��6:   8   � ��6V   �� 5�   "   $ ToolBarThumb��6;    � ��$ 10��6U   �� 5�   "   $ ToolBarThumb��6:    � ��$
 Auto��6T   �� 5�   "   $ ToolBarThumb��6;    � ��$ 	-1,-3,0,0q�6U   �� 5�   "   $ ToolBarThumb��6<    � ��$ 5,6,6,1q�6V   �� 5�   "   $ ToolBarHeader��6;    � ��$ 0,0,0,4q�6V   �� 5�   "   $ PART_ToolBarPanel��6;    � ��$ 1,0,2,2q�6Z   �� 5�   "   $ ToolBarThumb��6C    � ��$	 Top=�6]   �� 5�   "   $ ToolBarHeader��6C    � ��$	 Top=�6^   �� 5�   "   $ OverflowGrid��6H    � ��$ Stretch=�6b   �� 5�   "   $ OverflowGrid��6F    � ��$ Bottom=�6`   �� 5�   "   $ OverflowPopup��6>    � ��$ Right=�6Y   �� 5�   "   $ MainPanelBorder��6;    � ��$ 0,0,0,11q�6X   �� 5�   "   8   � ��6?   5�      P� 5�       � {�$ false��6;   . �5�   "   �� # � ��6?    � ��5�      5�      5�       5�      �� 5�      	 6   �� #
 Zr� true6b   .a�5�      ��  � ��# � ��63   5�      5�      5�      .��5�      � 5 � RowDefinitions5 5�   
   �� 5�      $
��Auto �6   5�      �� 5�      6   .+�5�   
   �� $��0��6   ���	#FF73D7AC
������$��0,0,0,2��6F   c� 5�   
   #���  6   ���	#FF73D7AC6 `� IsLocked$
6 True��6Q   .@�5�      �� .��5�      �� $��/Images/Logo2.png��6   $	��100��63   $��25��6?   5�      �� 5�      
�������6-   �� 5�      -   5        $��Segoe UI Semibold)�5�      
�������$��18(�6G   .��6j   (&Создать точку отката6�   �� 5�      
�������6-   �� 5�      -   5        $��	btnExport��5�      $��Segoe UI Semibold)�6&   
�������$��18(�6X   .��6~   ,*Применить точку отката6�   5�      � 5�   
   $��1��6   7 � ColumnDefinitions7 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      5 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      .+�5�      �� $��0��6   $��5��6(   ���	#FF73D7AC69   &   System.Windows.Controls.DataGrid  5�      -   5        $��dgTableInfo��5�      $��1��6*   $��1��67   $��5��6G   $��4��6[   8   CanUserAddRows$8 False��6l   9   CanUserDeleteRows$9 False��6�   :   CanUserReorderColumns$: False��6�   ;   
IsReadOnly$
; True��6�   <   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$< * 6�   =   SelectionMode$= Single=�6�   5�      �� 5�      $��0��6   $��0��6&   $��5,0,5,0q�66   $��Center=�6G   .+�5�      �� $%��Выберите таблицу��6   $��14(�64   $��Segoe UI Semibold)�6B   
�������6a   �� 5�      -   5        $��cbTables��5�      $��Segoe UI Semibold)�6+   .@�5�      �� -   5        $��TypeOfEquipment��5�   #   $��Segoe UI Semibold)�6:   > �� 
IsSelected$
> True��6Y   .��6k   #!Типы оборудования6~   �� 5�      -   5        $��WorkSchedule��5�   #   $��Segoe UI Semibold)�67   .��6V   Графики работы6f   �� 5�      -   5        $
��Post��5�   #   $��Segoe UI Semibold)�6/   .��6N   Должности6Y   �� 5�      -	   5        $��ReasonOfDismissal��5�   #   $��Segoe UI Semibold)�6<   .��6[   %#Причины увольнения6o   �� 5�      -
   5        $��TypeOfResearch��5�   #   $��Segoe UI Semibold)�69   .��6X   #!Типы исследования6k   �� 5�      -   5        $��TypeOfVacation��5�   #   $��Segoe UI Semibold)�69   .��6X   Типы отпуска6f   �� 5�      -   5        $��PayType��5�   #   $��Segoe UI Semibold)�62   .��6Q   Типы выплат6^   �� 5�      -   5        $
��User��5�   #   $��Segoe UI Semibold)�6/   .��6N   Пользователи6\   5�      5�      �� 5�      $��0��6   $��5��6)   $��Center=�66   .+�5�      �� -   5        $��btnExit��5�      $��
Назад��6)   $��Center=�69   $��Center=�6V   $��30��6q   $��88��6}   $��18(�6�   $y�Visible=�6�   ���	#FF77D8AF
�������
�������$��Segoe UI Semibold)�6�    5�      ��%^   '��       �� 5�      " ��6    .�5�      ��  �@��CornerRadius$ 5��6=   5�      5�      5�      �� 5�      -   5        $��btnClose��5�      $��
Выход��6*   $��Center=�6:   $��Center=�6W   $��30��6r   $��88��6~   $��18(�6�   $y�Visible=�6�   ���	#FF77D8AF
�������
�������$��Segoe UI Semibold)�6�   $��0,5,0,0q�6	   5�      ��%^   '��       �� 5�      " ��6    .�5      ��  �@��CornerRadius$ 5��6=   5     5     5     5     �� 5     -   5        $��btnAdd��5     $��4��6#   $��Добавить��63   $��Center=�6F   $��Bottom=�6c   $��0,0,0,5q�6~   $��18(�6�   $��Segoe UI Semibold)�6�   
����������	#FF73D7AC���	#FF73D7AC 5     ��%^   '��       �� 5     " ��6   .�5     ��  �@��CornerRadius$ 5��69   5	     5
     5     �� 5     -   5        $��btnEdit��5     $��5��6$   $��Изменить��64   $��Center=�6G   $��Bottom=�6d   $��0,0,0,5q�6   $��18(�6�   $��Segoe UI Semibold)�6�   
����������	#FF73D7AC���	#FF73D7AC 5     ��%^   '��       �� 5     " ��6   .�5     ��  �@��CornerRadius$ 5��69   5     5     5     �� 5     $��1��6   $��2��6)   $��Bottom=�6=   ? �� Orientation$? 
Horizontal=�6X   .+�5     �� -   5        $��tbSearch��5     $	��150��6*   $��18(�66   $��5,0,0,5q�6D   .��6U    5     ��%^   '��       �� 5     " ��6    .�5     ��  �@��CornerRadius$ 5��6=   5     5     .��6)   5     �� 5     -   5        $��	btnSearch��5     $��
Найти��6+   $��5,0,0,5q�6;   $��18(�6L   $��Segoe UI Semibold)�6Z   
����������	#FF73D7AC���	#FF73D7AC 5     ��%^   '��       �� 5     " ��6    .�5     ��  �@��CornerRadius$ 5��6=   5     5      5!     5"     5#     5$     5%     