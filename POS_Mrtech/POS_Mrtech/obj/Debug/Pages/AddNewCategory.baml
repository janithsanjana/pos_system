   M S B A M L   `   `   `  ����E  APOS_Mrtech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:POS_Mrtech.PagesPOS_Mrtech.Pages  5      K*clr-namespace:POS_Mrtech.View.UserControlsPOS_Mrtech.View.UserControls  5      %    POS_Mrtech.Pages.AddNewCategory   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:POS_Mrtech.Pages     5      CUserControls*clr-namespace:POS_Mrtech.View.UserControls     5        N� Title$  AddNewCategory��5
      .��5      � $��0,30,0,0q�6   .+�5   
   �� $��Add New Category��6   $��Center=�6,   $	��Top=�6I   $��25(�6a   $
��Bold"�6o   
�������$��0,10,0,0q�6�   �� 5   
    �� Orientation$ Vertical=�6   $��0,80,0,0q�6,    � 	Resources 5      .   (POS_Mrtech.View.UserControls.TextBoxComp �� 
TargetType �� Property �� Value��%�   '        �� 5      "  6   .�5      ��  � ��$ 50��6/   �� 5       � ��$ 60, 10q�6/   �� 5       � ��$	 320��6.   5      5      .+�5        -   5          Name$ tb_categoryName��5   '      Placeholder$ Category Name��6@   �� 5      $ 
Horizontal=�6   $��Center=�62   .+�5        -   5        $ tb_subCategoryName��5   +   $ Sub Category��6G   $��
50,10,0,10q�6b   �� 5      -   5         ��Name$ 	addButton��5      $��40��6K   $��40��6V   
������ 
������ $��10,0,0,0q�6�   $��0q�6�   .��5      F� 
�������$��36��6(   $��36��63   �����@f@]� �@]� @]� �@]� @f��ا @f��ا @]� ���j @]� ���j �ا ��ا �ا ��ا ��j �@]� ��j �@]� �ا �@f�ا ���!��- �@KL ��- �P[; ��- ��- P[; ��- @KL ���- ��!�@KL @o@ �� �� ���!@o@�@o@��! �� �� �@o@@KL �@o@P[; ��2��- ��!��- 		 �� Stretch$
	 Fill=�6�   5      5      �� 5      -   5        
 ��Name$
 containerStackPanel��5      5!        5"      -   5        $ tb_CategoryDiscription��5"   '   $ Discription��6G   �� 5#      $ 
Horizontal=�6   $��Center=�62   .+�5$      *   $POS_Mrtech.View.UserControls.HeroBtn  $��0,20,5,0q�6'      Content$
 Save��69   $	��100��6H   $��30��6T   ,   &POS_Mrtech.View.UserControls.CancelBtn  5%      -   5          Name$ ResetBtn��5%   )   ,   &POS_Mrtech.View.UserControls.CancelBtn   Click$ ResetButton_Click��6u   $��5,20,0,0q�6;      Content$ Reset��6M   $	��100��6]   $��30��6i   6u   5&      5'      5(      5)      