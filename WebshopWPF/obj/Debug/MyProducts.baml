   M S B A M L   `   `   `  ����E  AWebshopWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WebshopWPF
WebshopWPF  5   	       WebshopWPF.MyProducts   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WebshopWPF     5   	     � Title$  
MyProducts��5   	   $	��450��6   $	��350��6)    � 
ResizeMode$ CanMinimize=�65    � WindowStartupLocation$ CenterScreen=�6N    � AllowsTransparency . 
������  � WindowStyle$
 None=�5
   	   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $	��380 �6    �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   ��5      �� 5      .��5      �  � Color$ 	#FF404040��6'    � Offset$	 0.0Q�69   � 5      $ #ff8c00��6'   $	 1.2Q�67   5      5      �� 5      -   5        	 ��Name$	 ProductsListView��5      $��0��61   
���������5      �� 5      .��5      � $ 	#FF404040��6'   $	 0.0Q�69   � 5       $ #ff8c00��6'   $	 1.2Q�67   5!      
 �� View
 5#      �� 5$      .P�5%      �� $
��Naam��6)    �� Width$	 110��6]    �� DisplayMemberBinding 67   �� *Name+6]   �� 5&      $��Prijs��6)   $	 100��6_    68   �� *Price+6_   �� 5'      $��Aantal��6)   $	 100��6a    69   �� *Amount+6a   5(      5*      �� 5,       �� Orientation$ 
Horizontal=�6   $��1��62   .+�5.      �� -   5         ��Name$ StaticSaldoLabel��5.      $��	helvetica)�64   $��Light"�5/      $��22(�50      
�������$��Center=�52      
������ $��0q�54      $��80��55      $
��Left=�56       J� Opacity$	 0.5Q�57      $��25��58      $��10,7,0,37.6q�59      {�.  $��
Saldo: €��5;      �� 5<      -   5        $ DynamicSaldoLabel��5<      $��	helvetica)�65   $��Light"�5=      $��22(�5>      
�������$��Center=�5@      
������ $��0q�5B      $��51��5C      $
��Left=�5D      $	 0.5Q�5E      $��25��5F      $��5,7,55,37.6q�5G      {�.  5H      �� 5J      -   5         ��Name$ DashboardButton��5J      $	��140��62   $��40��6>   $��	Dashboard��6J   $��
0, 0, 0, 0q�6|   5L      5N      5O      5P      