   M S B A M L   `   `   `  ����I  ESuperMarketAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:SuperMarketAPISuperMarketAPI  5   	       SuperMarketAPI.Login   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   (localclr-namespace:SuperMarketAPI  5   	     � Title$  Login��5	   	   $	��500��5
   	   $	��350��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   .��5      � .+�5   
   �� $	��250��6   $��Bottom=�5      ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�5   &   .��5      �  � Color$ 	#FFD9D0E8��6#   � 5      $ 	#FF493E8D��6#    � Offset$ 1Q�5   #   � 5      $ 	#FF523985��6#   $	 0.5Q�5   #   5      5      �� 5   
   $��Assets/Shop.png��6   $	��100��5      $	��100��5      $	��Top=�5      $��20q�5        �� BitmapScalingMode$
 Fant=�5!      �� 5"   
   $	��280��6   $	��240��5#      
�������$��Bottom=�5%      $��0,100q�5&       �� RadiusY$ 22��5'      	 �� RadiusX$	 22��5(      
 J� Effect
 5)      3  -System.Windows.Media.Effects.DropShadowEffect  5*         
BlurRadius$ 10Q�6#      Color$ 	#FFC1C0C0��5+   #      RenderingBias$ Quality=�5,   #      ShadowDepth$ 1Q�5-   #   5/      � 50   
   $	��280��6   $	��240��51      $��Bottom=�52      $��0,100q�53      .+�54      �� $��LOGIN��6   $��Center=�55      $	��Top=�56      $��5q�57      
�������$��18(�59      �� 5:      $��Center=�6   $��10q�5;      .+�5<      �� )  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 USER��6      MaterialDesignTextBox#��[  5=      $
��0,10q�5>      G� 5?      $ PASSWORD��6    ) %MaterialDesignFloatingHintPasswordBox#��[ 5@      $
��0,10q�5A      5B      5C      �� 5E   
   $��Login��6   
�������$��14(�5G      $��Medium"�5H      $��Bottom=�5I      $
��0,85q�5J      ��5K      �� 5L       �� 
TargetType" ��6   .�5M      ��  �� Property � �� �� Value �	#FFB571F95N       �� Triggers 5O      P� 5P       P� Property �@J�IsMouseOver P� Value$
 True��5Q   "   . �5R      ��  � �� �	#FF2900515S   %   5T      5V      ��5X      �� 5Y       �� 
TargetType" ��6"   .R�5Z      �� $	��150��6   $��25��5[       �� CornerRadius$ 12��5\      #��z��5]      ._�5^      �� $��Center=�6+   $��Center=�5_   +   5`      5a      5c      5d      5e      