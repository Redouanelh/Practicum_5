   M S B A M L   `   `   `  ����E  AWebshopWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WebshopWPF
WebshopWPF  5   	       WebshopWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WebshopWPF     5   	     � Title$  	Dashboard��5   	   $	��500��6   $	��900��6(    � Icon$ webshop-icon.png��64    � 
ResizeMode$ CanMinimize=�6L    � WindowStartupLocation$ CenterScreen=�6e    � WindowStyle$
 None=�5	   	    � AllowsTransparency . 
������ .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $	��400 �6    �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   ��5      �� 5      .��5      �  � Color$ 	#FF404040��6'   	 � Offset$		 0.0Q�69   � 5      $ #ff8c00��6'   $		 1.2Q�67   5      ._�5      �� 
 �� Stretch$

 Fill=�6   
�������	 �� X2$ 1��65   $��0, 300, 0, 0q�6<   5      � 5       � ColumnDefinitions 5      �� 5      �� 5       .+�5#      �� -   5         ��Name$ ProductsListView��5#      $��1��65   $��0��6E   
���������5$      �� 5%      .��5&      � $ 	#FF404040��6+   $		 0.0Q�6=   � 5'      $ #ff8c00��6+   $		 1.2Q�6;   5(       �� View 5*      �� 5+      .P�5,      �� $
��Naam��6S    �� Width$	 150��6a    �� DisplayMemberBinding 6-   �� *Name+6a   �� 5-      $��Prijs��6T   $	 150��6c    6-   �� *Price+6c   �� 5.      $��Voorraad��6T   $	 130��6f    6-   �� *Stock+6f   5/      51      �� 53       �� Orientation$ Vertical=�6   $��0��64   $��0��6D   .+�54      �� -   5         ��Name$ RefreshButton��54      $	��200��64   $��40��6@   $��22(�6L   $��Ververs producten��6Z   $��0, 145, 0, 0q�6�   �� 55      -   5        $ 	BuyButton��55      $	��200��60   $��40��6<   $��22(�6H   $��Koop product��6V   $��0, 20, 0, 0q�6�   56      58      �� 5:      $ 
Horizontal=�6   $��0, 50, 0, 0q�62   $��1��6G   .+�5;      �� -   5        $ MyProductsButton��5;      $	��140��63   $��40��6?   $��Mijn producten��6K   $��10,-15,210,25.4q�6�   �� 5=      -   5         ��Name$ StaticSaldoLabel��5=      $��	helvetica)�64   $��Light"�5>      $��22(�5?      
�������$��Center=�5A      
������ $��0q�5C      $��80��5D      $
��Left=�5E       J� Opacity$	 0.5Q�5F      $��25��5G      $��10,-5,0,30.4q�5H      {�.  $��
Saldo: €��5J      �� 5K      -   5        $ DynamicSaldoLabel��5K      $��	helvetica)�65   $��Light"�5L      $��22(�5M      
�������$��Center=�5O      
������ $��0q�5Q      $��51��5R      $
��Left=�5S      $	 0.5Q�5T      $��25��5U      $��5,-5,210,30.4q�5V      {�.  5W      �� 5Y      -   5        $ CloseButton��5Y      $	��140��6.   $��40��6:   $��Applicatie sluiten��6F   $��30,-13,0,23.4q�6}   5Z      5\      5]      5^      