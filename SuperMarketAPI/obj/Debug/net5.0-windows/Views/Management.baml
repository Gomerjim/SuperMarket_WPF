   M S B A M L   `   `   `  ����I  ESuperMarketAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:SuperMarketAPISuperMarketAPI  5   	   D @FluentWPF, Version=0.9.0.1, Culture=neutral, PublicKeyToken=nullP6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPFSourceChord.FluentWPF 5   	       SuperMarketAPI.Management   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:SuperMarketAPI     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   ?fw6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPF  5   	   $	��700��5   	   $
��1200��5	   	     � WindowStartupLocation$  CenterScreen=�5
   	   )  #SourceChord.FluentWPF.AcrylicWindow   Enabled$
 True��5   	      AcrylicWindowStyle$
 None=�5   	   .��5      � *  $SourceChord.FluentWPF.PointerTracker   Enabled$
 True��6    � ColumnDefinitions 5   
   �� 5      -   5         ��Name$ ListViewColumn��5      $	��300 �5      �� 5      .+�5   
   �� $��1��6   $
��0,25q�5       �� Orientation$ 
Horizontal=�5      .+�5      �� .@�5      �� .��5      �� $ 
Horizontal=�6!   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Home=�62   $��10q�5   2   �� 5      $
��Home��6$   $��Center=�5   $   $��18(�5   $   ��5    $   �� *ListViewSize+5!      5"      5#      5$      �� 5%   
   $��1��6   $��0,100q�5&      $ 
Horizontal=�5'      .+�5(      �� .@�5)      �� .��5*      �� $ 
Horizontal=�6!   .+�5+        $ Human=�62   $��10q�5,   2   �� 5-      $��
Categorias��6$   $��Center=�5.   $   $��18(�5/   $   ��50   $   �� *ListViewSize+51      52      �� 53      .��54      �� $ 
Horizontal=�6!   .+�55        $ TextBoxMultipleOutline=�62   $��10q�56   2   �� 57      $��Produtos��6$   $��Center=�58   $   $��18(�59   $   ��5:   $   �� *ListViewSize+5;      5<      5=      5>      �� 5?   
   $��1��6   $ 
Horizontal=�5@      $��Bottom=�5A      .+�5B      ��    ButtonTemplate#��[  6   $��30��5C      $��30��5D      .��5E        $	 Add=�6*   $	��Top=�5F   *   $��25��5G   *   $��25��5H   *   5I      �� 5J      #��[  6   $��30��5K      $��30��5L      .��5M        $ Delete=�6*   $	��Top=�5N   *   $��25��5O   *   $��25��5P   *   5Q      �� 5R      #��[  6   $��30��5S      $��30��5T      .��5U        $
 Edit=�6*   $	��Top=�5V   *   $��25��5W   *   $��25��5X   *   5Y      5Z      � 5[   
   $��2��6   
������� � RowDefinitions 5]      �� 5^      $	��100 �6    �� 5_      .+�5a      �� $��1��6   $��30q�5b      .+�5c      �� $��Utilizadores��6   $��0q�5d      $��Center=�5e      $��Center=�5f      $��20(�5g      .��6(   5h      5i      �� 5j      $��1��6   $��1��5k      $��50q�5l      .+�5m      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 ManagementDataGrid��5m      
��� � �
   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 * 5o         AutoGenerateColumns$ False��5q      ��5p      �� *Users+   Columns 5r      0  *System.Windows.Controls.DataGridTextColumn  5s      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nome��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5t   -   �� *Name+ �� Mode$ OneWay=�  5u      $ Idade��6-    5v   -   �� *Age+$ OneWay=�  5w      $ Contacto��6-    5x   -   �� *Phone+$ OneWay=�4	  .System.Windows.Controls.DataGridCheckBoxColumn	  5y      $ Admin?��61    5z   1   �� *	IsAdmin+$ OneWay=�5|      5}      5~      5      5�      