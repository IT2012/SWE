   M S B A M L   `   `   `  ����J  FListViewSandBox, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ListViewSandBoxListViewSandBox  5   	   E'clr-namespace:ListViewSandBox.ConverterListViewSandBox.Converter  5   	        ListViewSandBox.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   /localclr-namespace:ListViewSandBox     5   	   =	converter'clr-namespace:ListViewSandBox.Converter     5   	   -   5        $��MainWindows��5	   	     � Title$  
MainWindow��5   	   $	��500��5   	   $
��1200��5   	    � 	Resources 5
      <   6ListViewSandBox.Converter.BooleanToVisibilityConverter    BooleanToVisibilityConverterL   FListViewSandBox.Converter.InvertetBooleanToInvertetVisibilityConverter 0 ,InvertetBooleanToInvertetVisibilityConverter �� 
TargetType �� Property �� Value �� 
TargetType � RowDefinitions �� Orientation K� IsItemsHost)  #System.Windows.Controls.DataGridRow	 ��Name
 J� SnapsToDevicePixels �� 
StartPoint �� EndPoint � Offset � Color?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid � ColumnDefinitions?  9System.Windows.Controls.Primitives.DataGridCellsPresenter   
ItemsPanelA  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter   DetailsVisibility$   SelectiveScrollingOrientation;  5System.Windows.Controls.SelectiveScrollingOrientation   Vertical �� ConverterParameter&   System.Windows.Controls.DataGrid#   RowDetailsScrollingConverter �� 	Converter �� RelativeSource �� AncestorType:	  4System.Windows.Controls.Primitives.DataGridRowHeader7
  1System.Windows.Controls.DataGridHeadersVisibility
 
  Row!   HeadersVisibilityConverter  TxStyle*  $System.Windows.Controls.DataGridCell $  TreeViewHierarchicalDataTemplate �� DataType   ListViewSandBox.TreeNode �� ItemsSource �� CornerRadius �� Padding �� Path��%A
  &	        &	      'Q� &     '  O    &	 �    &	 �    7  7     5   
   61     5   
   6A   �� 5   
   " Q�6   .�5      ��  � �� 5      �� 5      " Q�6&   .R�5      � $��2q�6    5      �� 5   "   $
��Auto �60   �� 5   "   $��* �60   .+�5      �� $��PART_Header��6/   $��Header��5    /   $��20,10,20,10q�5!   /   $��Center=�5"   /   $��Center=�5#   /   �� 5%      $��1��6-   $��20,10,20,10q�5&   -   5'      5(      5*      �� 5,       � �� 5-      �� 5.      .R�5/      �� $��Center=�6%   $ 
Horizontal=�50   %    . 51   %   52      54      55      �� 56   
   "  6   .�57      ��  � ��
 �����6+   �� 58       �@=�ErrorTemplate 69   Z� �� 59       � �� 5:      �� 5;      "  6&   .R�5<      �� $	 
DGR_Border��6!   #��z��5=      #��z��5>      
 . ��5@      �� 5A   "   $ 0.5,0&�66   $ 0.5,1&�6I   .��5B   &   � $ 0Q�63   $ 	#AAFFFFAA��6>   � 5C   &   $ 1Q�63   $ 	#AAFFD455��6>   5D   #   ._�5F         5G   "   �� 5H   &   $
��Auto �67   �� 5I   &   $��* �67    5K   "   �� 5L   &   $��* �64   �� 5M   &   $
��Auto �64   .+�5O   "     $��1��69   #��z 5P   0   #
 z
 5Q   0     5R   "   $��1��6;   $��1��5S   ;   #y�z 5Y   ;    5T   ;   �� *AreRowDetailsFrozen+# Z # Z  �� "  5Y   ;   	  5Z   "   $��2��64   $ Vertical=�5[   +   y�5\   4   �� *HeadersVisibility+# Z # Z  �� "  5a      5b      5c      5e      5f      �� 5g   
   "  6!   .�5h      ��  � �� 5i      �� 5j      "  6&   .R�5k      �� $	 border��6!   
���  ��
������ $��1q�5n      
 . ._�5q      �� #
 z
 6/   5r      5s      5u      5v      �� 5w   
   "  5x   #    5y   #   �� *
Children+.R�5z      � .+�5|      �� 
��� E��$��1q�5~      $ 30��5      $ 20q�5�      y�5|      �� $ IsLast�8   ��5�      �� 5�      $ 0.5, 0&�6.   $ 0.5, 1&�6B   .��5�      � $ 	OrangeRed��6+   $ 0Q�6=   � 5�      $	 Red��6+   $ 1Q�67   5�      5�      �� 5�      
����+��$��1q�5�      $ 20q�5�      y�5�      �� $ IsLast�8  ��5�      �� 5�      $ 0.5, 0&�6.   $ 0.5, 1&�6B   .��5�      � $ DeepPink��6+   $ 0Q�6<   � 5�      $ 
DarkViolet��6+   $ 3Q�6>   5�      5�      �� 5�      $��20(�5�      $��Center=�5�      $��Center=�5�      $��10q�5�      ��5�      �� *Name+5�      5�      5�      5�      .��5�      �  5�   
   �� 5�      $
��Auto �6   �� 5�      $��* �6   �� 5�      $��20 �6   .+�5�   
   o� $
��Auto��6   $
��Auto��5�      
��� ��$	��Top=�5�      $��0��5�      $��Oblique$�5�      .@�5�      m� -   5        $��MDatei��5�      $��_Datei��5�      .@�5�      m� -   5        $��	MiCsvLoad��5�      $��CSV Datei einlesen��5�      5�      m� 5�      -   5        $��	MiCsvSave��5�      $��CSV Datei speichern��5�      5�      5�      m� 5�      -   5        $��MEinstellungen��5�      $��_Einstellungen��5�      .@�5�      m� $��Optionen��6   m� 5�      $��About��6   5�      5�      �� 5�   
   $��1��6   .@�5�      �� -   5        $��TableTabItem��5�      $��Tabelle��6*   .��5�      �� .u�5�      �  5�      �� 5�      $��* �6,   �� 5�      $
��Auto �6,   .+�5�        -   5        $��DGrid��5�   #   �� 5�      -   5        $��GenTree��5�   !   $��1��5�   !   $��GenTree��5�   !   5�   :   5�      5�      5�      �� 5�      -	   5        $��BaumTabItem��5�      $
��Baum��6)   .��5�      �� .u�5�      � .+�5�      R� -
   5        $
��Tree��5�   #   
�������#��[ 5�   #   ��5�   #   �� *CustomTreeViewItemStyle+5�      5�      5�      5�      �� 5�      -   5        $��RegelnTabItem��5�      $��Regeln��6+   {�.  5�      5�      5�      5�      