   M S B A M L   `   `   `  ����E  APOS_Mrtech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:POS_Mrtech
POS_Mrtech  5   	   K*clr-namespace:POS_Mrtech.View.UserControlsPOS_Mrtech.View.UserControls  5   	       POS_Mrtech.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:POS_Mrtech     5   	   CUserControls*clr-namespace:POS_Mrtech.View.UserControls     5   	   -   5        $	��550��5	   	   $	��800��6     � WindowStyle$
  None=�5
   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency .  � Title$ Login��5   	   .��5      ��  �� CornerRadius$ 20��6   ���#212529$��3q�5      
���   �._�5   
   �  � RowDefinitions 5      �� 5      $��50 �6    �� 5      .+�5      �  � ColumnDefinitions 5      �� 5      �� 5      $��25 �6'   �� 5      $��10 �6'   .+�5"      �� $��LOG IN��6   
�������$��30(�5$      $��
Montserrat)�5%      $��0��5&      $��Center=�5'      $��20,0,0,0q�5(      �� 5*      -   5         ��Name$ closeBtn��5*      ���#00bfff$��X��5,      
���   �$��20(�5.      $��
Montserrat)�5/      	 � Cursor$
	 Hand��50      $��1��51      ��54      �� 55      
 �� 
TargetType"
 ��6*   .R�57      �� $��25��6%   $��25��60   $ 5��58   %   #��z��59   %   ._�5;   "   �� $��Center=�63   $��Center=�5<   3   5>      5?      5A      5B      �� 5D      $	��250��6   $��2��5E      .+�5F      �� $��/Pages/MrTechLogo.png��6   $��70��5G      �� 5H      $��P  O  S��6   
�������$��30(�5J      $��Medium"�5K      $��
Montserrat)�5L      $��Center=�5M      �� 5N      $��point of sale System��6   
�������$��15(�5P      $��Light"�5Q      $��
Montserrat)�5R      $��Center=�5S      �� 5V      -   5         ��Name$ userLbl��5V      $��	User Name��5W      
�������$��18(�5Y      $��Light"�5Z      $��
Montserrat)�5[      $
��Left=�5\      $��0,40,0,0q�5]      �� 5_      -   5         ��Name$ userName��5_      $��0,5,0,0q�5`      $��15(�5a      $��
montserrat)�5b      
������ 
�������
�������$��0,0,0,2q�5f      $��40��5g      $��Center=�5h      .��5i      5k      �� 5m      $��Password��6   
�������$��18(�5o      $��Light"�5p      $��
Montserrat)�5q      $
��Left=�5r      $��0,30,0,0q�5s      G� 5u      -   5         G�Name$ password��5u      $��0,5,0,0q�5v      $��15(�5w      $��
montserrat)�5x      
������ 
�������
�������$��0,0,0,2q�5|      $��40��5}      $��Center=�5~      5�      �� 5�      -   5        $ errorBox��5�      $��0,10,0,0q�5�      
���  ��$
��12px(�5�      �� 5�      -   5        $ loginBtn��5�      ���#00bfff$��Login��5�      
���   �$��15(�5�      $��
Montserrat)�5�      $
	 Hand��5�      $��1��5�      $��0,40,0,0q�5�      ��5�      �� 5�      "
 ��6*   .R�5�      �� $	��150��6%   $��25��61   $ 5��5�   %   #��z��5�   %   ._�5�   "   �� $��Center=�63   $��Center=�5�   3   5�      5�      5�      5�      5�      5�      5�      