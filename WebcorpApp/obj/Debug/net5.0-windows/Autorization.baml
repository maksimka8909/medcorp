   M S B A M L   `   `   `  ����E  AWebcorpApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WebcorpApp
WebcorpApp  5   	       WebcorpApp.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WebcorpApp     5   	     � Title$  Авторизация��5   	   $	��450��6   $	��800��6-    � 
ResizeMode$ CanResizeWithGrip=�6<    � WindowState$ 	Maximized=�5	   	    � WindowStartupLocation$ CenterOwner=�6!    � WindowStyle$ ThreeDBorderWindow=�5
   	   .��5      �  J� OpacityMask
 �   ����	#FF77D8AF.+�5   
   �� $��Center=�6   $	��122��6-   $��0 10 0 0q�6:   $	��Top=�6M   $	��142��6e   $��Images/Logo.png��6q   $
��Fill=�6�   $��1��6�   � 5   
   $��Center=�6   $��0 50 0 0q�6,   $��Center=�6>    � RowDefinitions 5      �� 5      �� 5      �� 5      .+�5      �� $��0��6   $��Center=�6&   .+�5      �� $��
Логин��6   $��18(�6)   
�������$��Segoe UI Semibold)�6J   �� 5      -   5        $��tbLogin��5      $
��Left=�6*    �� TextWrapping$
 Wrap=�6E   $	��Top=�6Y   $	��200��6q   $��30��6}    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��18(�6�   $��1��6�   4  .System.Windows.Automation.AutomationProperties	   IsColumnHeader$
	 True��6�   .��6�   
 � 	Resources
 5       �� 
TargetType �� Property �� Value��%^   '��       �� 5      " ��6    .�5      ��  �@��CornerRadius$ 5��6=   5      5      .��6)   z�5      V� 5      .~�5      ��  �� ScaleY$ 1Q�6-   �� 5      �� 5       T� 5!      5"      .��5$   /   5%      5&      �� 5'      $��1��6   $��Center=�6&   .+�5(      �� $��Пароль��6   $��18(�6*   
�������$��Segoe UI Semibold)�6K   G� 5)      -   5        $��
pbPassword��5)      $
��Left=�60   $	��Top=�6K   $	��200��6c   $��30��6o   $��18(�6{   $��1��6�   
 5*      ��%^   '��       �� 5+      " ��6    .�5,      ��  �@��CornerRadius$ 5��6=   5-      5.      5/      50      � 51      $��2��6   $��0 10 0 0q�6     � ColumnDefinitions 52      �� 53      �� 54      .+�56      �� -   5        $��btnEnter��56      $��0��6)   $��
Войти��69   $��Center=�6I   $	��Top=�6f   $��30��6~   $��88��6�   $��18(�6�   $y�Visible=�6�   ���	#FF77D8AF
�������
�������$��Segoe UI Semibold)�6�   
 57      ��%^   '��       �� 58      " ��6    .�59      ��  �@��CornerRadius$ 5��6=   5:      5;      5<      �� 5@      -   5        $��btnExit��5@      $��
Выход��6(   $��1��68   $
��Left=�6I   $	��Top=�6d   $��30��6|   $��87��6�   $��18(�6�   $y�Visible=�6�   ���	#FF77D8AF
�������
�������$��Segoe UI Semibold)�6�   
 5A      ��%^   '��       �� 5B      " ��6    .�5C      ��  �@��CornerRadius$ 5��6=   5D      5E      5F      5G      5I      5J      5K      