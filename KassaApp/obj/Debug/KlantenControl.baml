   M S B A M L   `   `   `  ����C  ?KassaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:KassaAppKassaApp  5          KassaApp.KlantenControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:KassaApp     5      .��5	      � ��5
   
   �� 5        �� ImageSource$  Pictures/KlantControl.png��6   .+�5   
   �� -   5         ��Name$ KlantNaamBox��5      $
��Left=�6(   $��32��6C   $��	10,10,0,0q�6O    �� TextWrapping$
 Wrap=�6b   $��
Klant Naam��6v   $	��Top=�6�   $	��132��6�   ���	#FF0023AC$��20(�6�   
�������$
��Bold"�6�   
���   �6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DGCustomers��5      $	��332��6(   $��
10,113,0,0q�65   $	��280��6I   ���	#FF00125B   AutoGenerateColumns .  $
��Left=�6�   $	��Top=�6�      CanUserAddRows .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Klant��6a   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� *Naam+
   ClipboardContentBinding
 6>   Z� 6a     5         
Foreground
 �   �$
 Stad��6t   	 6%   �� *Stad+
 6>   Z� 6t     5      $ Nummer��6i   	 6%   �� *MobielNummer+
 6F   Z� 6i     5      $ E-Mail��6b   	 6%   �� *EMail+
 6?   Z� 6b   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      ��  ��Name$ btnVerwijderenKlant��6%   -   5        $��Delete��5   B   6S   5      5      5      �� 5   
   $
��Left=�6   $��	10,76,0,0q�6/   $
��Wrap=�6B   $��Klanten:��6V   $	��Top=�6f   $��24(�6~   $
��Bold"�6�   
�������6�   �� 5   
   -   5        $ KlantStadBox��5      $
��Left=�6(   $��32��6C   $��
147,10,0,0q�6O   $
 Wrap=�6c   $��
Klant Stad��6w   $	��Top=�6�   $	��155��6�   ���	#FF0023AC$��20(�6�   
�������$
��Bold"�6�   
���   �6�   �� 5   
   -   5        $ KlantMobielBox��5      $
��Left=�6*   $��32��6E   $��
307,10,0,0q�6Q   $
 Wrap=�6e   $��Klant Mobiel��6y   $	��Top=�6�   $	��166��6�   ���	#FF0023AC$��20(�6�   
�������$
��Bold"�6�   
���   �6�   �� 5    
   -   5        $ KlantMailBox��5       $
��Left=�6(   $��32��6C   $��
478,10,0,0q�6O   $
 Wrap=�6c   $��Klant EMAIL��6w   $	��Top=�6�   $	��219��6�   ���	#FF0023AC$��20(�6�   
�������$
��Bold"�6�   
���   �6�   �� 5!   
   -   5        $ KlantUpdateBtn��5!      $��Update��6)   $
��Left=�6:   $��
702,47,0,0q�6U   $	��Top=�6i   $��88��6�   $��32��6�   $��20(�6�   $
��Bold"�6�   ���	#FF0034FF
���   �
�������6   �� 5"   
   -   5        $ KlantOpslaanBtn��5"      $��Opslaan��6*   $
��Left=�6<   $��
702,10,0,0q�6W   $	��Top=�6k   $��88��6�   $��32��6�   $��20(�6�   $
��Bold"�6�   ���	#FF0034FF
���   �
�������6  5$      5%      