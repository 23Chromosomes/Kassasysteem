   M S B A M L   `   `   `  ����C  ?KassaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:KassaAppKassaApp  5          KassaApp.BestelControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:KassaApp     5      $
��Auto��5   7   $
��Auto��6D   .��5	      � $��0q�6     � ColumnDefinitions  5
   
   �� 5      �� 5      �� 5      ��5   
   �� 5       �� ImageSource$/ )Pictures/BackgroundProductUserControl.png��6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	DGProduct��5      $��
10,10,0,10q�6&   ���	#FF761E1A
���   �   AutoGenerateColumns .     CanUserResizeRows .     CanUserAddRows .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Naam��6h   	   
FontWeight$
	 Bold"�6v   
   FontSize$
 16Q�6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *ProductNaam+   ClipboardContentBinding 6E   Z� 6�     5      $ Omschrijving��6v   $
	 Bold"�6�   $
 16Q�6�    6%   �� *producttypen.Omschrijving+ 6S   Z� 6�     5      $ Prijs��6b   $
	 Bold"�6q   $
 16Q�6�    6%   �� *Prijs+ 6?   Z� 6�   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ 
Afbeelding��6)      CellTemplate 5      �� 5      .R�5      ��  ��Name$ afbItem��6$   $��64��6S   $��64��6^   ��65   �� *
Afbeelding+6^   5      5      5        5    
   -   5        $ DGBestelling��5       $��
0,10,10,75q�6)   $��2��6=   ���	#FF761E1A
���   � .   .   .   .  5!        5"      $
 Naam��6h   $
	 Bold"�6v   $
 16Q�6�    6%   �� *ProductNaam+ 6E   Z� 6�     5#      $ Omschrijving��6v   $
	 Bold"�6�   $
 16Q�6�    6%   �� *producttypen.Omschrijving+ 6S   Z� 6�     5$      $ Prijs��6b   $
	 Bold"�6q   $
 16Q�6�    6%   �� *Prijs+ 6?   Z� 6�     5%      $ Hoeveelheid��6h    6%   �� *Hoeveelheid+ 6E   Z� 6h   5'      �� 5(   
   $��2��6   $��	0,0,10,45q�6"   $��Bottom=�65   $��30��6P   $��0q�6\   $��Stretch=�6h   ���	#FF761E1A
���   �$��Totaal:��6�   $��20(�6�   $
��Bold"�6�   $��Right=�6�   $	��155��6  �� 5)   
   -   5         ��Name$ 	BestelBtn��5)      $��Bestel��6$   $��2��65   $��Right=�6E   $��	0,0,10,10q�6a   $��Bottom=�6t   $��75��6�   ���	#FFBD0800$��35��6�   $
��Bold"�6�   $��20(�6�   6�   �� 5*   
   -   5        $ AnnuleerBtn��5*      $��Annuleer��6&   $��2��69   $��Right=�6I   $��	0,0,90,10q�6e   $��Bottom=�6x   $��75��6�   ���	#FFBD0800$��35��6�   $��16(�6�   $
��Bold"�6�   �� 5+   
   $��1��6   $
��Left=�6    $	��100��6;   $��125,166,0,0q�6H   $	��Top=�6]   $	��100��6u   �� 5,   
   -   5         ��Name$ NaamSelectorCMB��5,      $��1��6,   $��
51,10,42,0q�6<   $	��Top=�6P    �� DisplayMemberPath$
 Naam��6h   �� 5-   
   -   5         ��Name$ HoeveelheidBox��5-      $��2��6*   $��Right=�6:   $��30��6V   $��
0,0,165,45q�6b    �� TextWrapping$
 Wrap=�6v   $��Bottom=�6�   $	��101��6�   $��18(�6�   $��
Heveelheid��6�   ���	#FF761E1A6�   5.      5/      