   M S B A M L   `   `   `  ����E  AWebshopWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WebshopWPF
WebshopWPF  5   	       WebshopWPF.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WebshopWPF     5   	     � Title$  Login��5   	   $	��450��6   $	��350��6$    � Icon$ webshop-icon.png��60    � 
ResizeMode$ CanMinimize=�6H    � WindowStartupLocation$ CenterScreen=�6a    � AllowsTransparency . 
������  � WindowStyle$
 None=�5
   	   .��5      �� 
�������$��1q�6!    �� CornerRadius$ 10��65   ._�5   
   � .+�5      �  � RowDefinitions 5      �� 5      �� 5      .+�5      �� $ 10��6   $��2��6+   ��5      �� 5      .��5      �  � Color$ 	#FF404040��6+   	 � Offset$		 0.0Q�6=   � 5      $ #ff8c00��6+   $		 1.2Q�6;   5      5      �� 5      $��Center=�6   .+�5      �� $��webshop-icon.png��6   $��80��66   �� 5      �� 5      $ ��Webshop Hogeschool Utrecht��6    $��Center=�5       $��20(�5!      $��	helvetica)�5"      
�������$��Light"�5$      �� 5%      -   5        
 ��Name$
 InvalidCombinationLabel��5%      $'��!Onjuist gebruikersnaam/wachtwoord��5&      $��Center=�5'      $��15(�5(      $��	helvetica)�5)      
�������$��Light"�5+      $��0, 20, 0, 0q�5,      $y�Hidden=�5-      5.      �� 50      $��1��6   .+�51      ��  �� Orientation$ 
Horizontal=�6!   .+�52      �� -   5         ��Name$ UsernameInput��52   "   $��	helvetica)�69   $��Light"�53      $��Gebruikersnaam��54      $��18(�55      
�������$��Center=�57      
������ $��0q�59      $	��235��5:      $
��Left=�5;       J� Opacity$	 0.5Q�5<      $��25��5=      $��48, 0, 0, 0q�5>      5?      �� 5@      $	��250��6   $��2��5A      
�������$	 0.5Q�5C      �� 5E      $ 
Horizontal=�6!   $��0, 20, 0, 0q�6:   .+�5F      G� -   5         G�Name$ PasswordInput��5F   &   $��	helvetica)�6=   $��Light"�5G       G� Password$ 
Wachtwoord��5H      $��18(�5I      
�������$��Center=�5K      
������ $��0q�5M      $	��235��5N      $
��Left=�5O      $	 0.5Q�5P      $��25��5Q      $��48, 0, 0, 0q�5R      5S      �� 5T      $	��250��6   $��2��5U      
�������$	 0.5Q�5W      �� 5Y      $ 
Horizontal=�6!   $��0, 50, 0, 0q�6:   .+�5Z      �� -   5         ��Name$ RegisterButton��5Z   !   $	��100��69   $��40��6E   $��
Registreer��6Q   $��45, 0, 60, 0q�6f   6|   �� 5[      -   5        $ LoginButton��5[   !   $	��100��66   $��40��6B   $��Login��6N   6^   5\      5^      5a      5b      5c      5d      