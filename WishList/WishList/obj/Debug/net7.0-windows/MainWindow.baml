   M S B A M L   `   `   `  ����C  ?WishList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WishListWishList  5   	       WishList.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WishList     5   	     � Title$  	Wish List��5   	   $	��350��6   $	��525��6(   .��5	      � .+�5
   
   �� -   5         ��Name$ WishListView��5
      $��10q�6)    �� View 5      �� 5      .P�5      ��  �� Width$ 50��6%   ��5      �� 5      -   5         ��Name$ SelectAllCheckBox��5   '   $��
Select All��6B   6{    �� CellTemplate 5      �� 5      .R�5   "   �� -   5         d� 	IsChecked 5   +   �� *
IsSelected+ �� Mode$ TwoWay=�6x   5      5      �� 5      $
��Icon��6%   $ 50��63    5      �� 5      .R�5   "   �� $��30��6@   $��30��6K   ��6(   �� *Icon+6K   5      5      �� 5      $��	Item Name��6%   $	 200��68    �� DisplayMemberBinding 6D   �� *
ItemName+�� 5      $��	Price ($)��6%   $	 100��68    6D   �� *Price+5       5"      �� 5#   
   -   5        $��Add Item��5#      $
��Left=�6$   $��Bottom=�6?   $��10q�6Z   6f   �� 5$   
   -   5        $��Remove Selected��5$      $
��Left=�6+   $��Bottom=�6F   $��
120,10,0,0q�6a   6u   5%      5&      