   M S B A M L   `   `   `  ����C  ?KassaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:KassaAppKassaApp  5          KassaApp.ProductControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:KassaApp     5      .��5	      � ��5
   
   �� 5        �� ImageSource$#  Pictures/ProductControlBG.jpg��6   .+�5   
   �� -   5         ��Name$ ProductToevoegenBtn��5      $��	Toevoegen��6.   $
��Left=�6B   $	��Top=�6]   $	��163��6u   $��35��6�   ���	#FF56EC10$
��Bold"�6�   $��18(�6�   
�������$��
10,322,0,0q�6�   6�   �� 5   
   -   5         ��Name$ ProductNaamBox��5      $
��Left=�6*   $��30��6E    �� TextWrapping$
 Wrap=�6Q   $	��163��6e   
�������$��18(�6�   $
��Bold"�6�   $��ProductNaam��6�   $��
10,182,0,0q�6�   $	��Top=�6�   �� 5   
   -   5        $ ProductBeschrijvingBox��5      $
��Left=�62   $��30��6M   $��
10,217,0,0q�6Y   $
 Wrap=�6m   $	��Top=�6�   $	��163��6�   
�������$��18(�6�   $
��Bold"�6�   $��Beschrijving��6�   �� 5   
   -   5        $ ProductPrijsBox��5      $
��Left=�6+   $��30��6F   $��
10,252,0,0q�6R   $
 Wrap=�6f   $	��Top=�6z   $	��163��6�   
�������$��18(�6�   $
��Bold"�6�   $
��1,00��6�   �� 5   
   -   5         ��Name$ ProductPlaatjeComboBox��5      $
��Left=�63   $��
10,287,0,0q�6N   $	��Top=�6b   $	��163��6z   $��30��6�   $��18(�6�   $
��Bold"�6�   
���������5      �� 5       �� EndPoint$	 0,1&�6&    �� 
StartPoint$	 0,0&�65   .��5      �  � Color$ 	#FFF0F0F0��6#    � Offset$ 0Q�65   � 5      $ White��6#   $ 1Q�61   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 
DGProducts��5      $��Right=�6'   $	��537��6C   $��0,182,803,0q�6P   $	��Top=�6e   $	��459��6}   
   AutoGenerateColumns
 .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Naam��6h      
FontWeight$
 Bold"�6v      FontSize$ 16Q�6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *ProductNaam+   ClipboardContentBinding 6E   Z� 6�     5      $ Omschrijving��6v   $
 Bold"�6�   $ 16Q�6�    6%   �� *producttypen.Omschrijving+ 6S   Z� 6�     5      $ Prijs��6b   $
 Bold"�6q   $ 16Q�6�    6%   �� *Prijs+ 6?   Z� 6�   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ 
Afbeelding��6)      CellTemplate 5      �� 5       .R�5!      ��  ��Name$ afbItem��6$   $��64��6S   $��64��6^   ��65   �� *
Afbeelding+6^   5"      5$        5%       5&      �� 5'      .R�5(      �� $ btnVerwijderen��6%   -   5        $��Delete��5(   =   6N   5)      5+      5-      �� 5.   
   -   5        $ ProductenSelectie��5.      $��O��6,   $
��Left=�68   $��178,182,0,0q�6S   $	��Top=�6h   $��30��6�   $��30��6�   ���	#FF0E22E86�   �� 5/   
   -	   5        $ ProductUpdateBtn��5/      $��Update��6+   $
��Left=�6<   $	��Top=�6W   $	��163��6o   $��35��6{   ���	#FF7E10EC$
��Bold"�6�   $��18(�6�   
�������$��
10,362,0,0q�6�   6�   50      51      