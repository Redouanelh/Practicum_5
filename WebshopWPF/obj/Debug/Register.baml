   M S B A M L   `   `   `  ����E  AWebshopWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WebshopWPF
WebshopWPF  5   	       WebshopWPF.Register   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WebshopWPF     5   	     � Title$  Register��5   	   $	��540��6   $	��350��6'    � Icon$ webshop-icon.png��63    � 
ResizeMode$ CanMinimize=�6K    � WindowStartupLocation$ CenterScreen=�6d    � AllowsTransparency . 
������  � WindowStyle$
 None=�5
   	   .��5      �� 
�������$��1q�6!    �� CornerRadius$ 10��65   ._�5   
   � .+�5      �  � RowDefinitions 5      �� 5      �� 5      .+�5      �� $ 10��6   $��2��6+   ��5      �� 5      .��5      �  � Color$ 	#FF404040��6+   	 � Offset$		 0.0Q�6=   � 5      $ #ff8c00��6+   $		 1.2Q�6;   5      5      �� 5      $��Center=�6   .+�5      �� $��webshop-icon.png��6   $��80��66   �� 5      �� 5      $ ��Webshop Hogeschool Utrecht��6    $��Center=�5       $��20(�5!      $��	helvetica)�5"      
�������$��Light"�5$      �� 5%      $!��Voer een gebruikersnaam in,��6   $��Center=�5&      $��15(�5'      $��	helvetica)�5(      
�������$��Light"�5*      $��0, 20, 0, 0q�5+      �� 5,      $%��wachtwoord genereren wij voor u��6   $��Center=�5-      $��15(�5.      $��	helvetica)�5/      
�������$��Light"�51      $��
0, 0, 0, 0q�52      �� 53      -   5        
 ��Name$
 UsernameInUse��53      $%��Gebruikersnaam is al in gebruik��54      $��Center=�55      $��15(�56      $��	helvetica)�57      
�������$��Light"�59      $��0, 20, 0, 0q�5:      $y�Hidden=�5;      5<      �� 5>      $��1��6   .+�5?      ��  �� Orientation$ 
Horizontal=�6!   .+�5@      �� -   5         ��Name$ UsernameInput��5@   "   $��	helvetica)�69   $��Light"�5A      $��Gebruikersnaam��5B      $��18(�5C      
�������$��Center=�5E      
������ $��0q�5G      $	��235��5H      $
��Left=�5I       J� Opacity$	 0.5Q�5J      $��25��5K      $��48, 0, 0, 0q�5L      5M      �� 5N      $	��250��6   $��2��5O      
�������$	 0.5Q�5Q      �� 5S      -   5         ��Name$ RegisterButton��5S      $	��120��65   $��40��6A   $��
Registreer��6M   $��50, 30, 60, 0q�6b   6y   �� 5U      $ 
Horizontal=�6!   $��0, 10, 0, 0q�6:   .+�5V      �� -   5        $ GeneratedPassword��5V   "   $��	helvetica)�6=   $��Light"�5W      $��18(�5X      
�������$��Center=�5Z      
������ $��0q�5\      $	��235��5]      $
��Left=�5^      $	 0.5Q�5_      $��25��5`      $��48, 0, 0, 0q�5a      {�.  5b      5c      �� 5d      $	��250��6   $��2��5e      
�������$	 0.5Q�5g      �� 5i      $ 
Horizontal=�6!   $��0, 40, 0, 0q�6:   .+�5j      �� -   5        $ LoginButton��5j   !   $	��120��66   $��40��6B   $��Terug naar de login��6N   $��110, 0, 60, 0q�6l   6�   5k      5m      5p      5q      5r      5s      