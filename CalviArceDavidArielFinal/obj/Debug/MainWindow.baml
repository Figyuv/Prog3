   M S B A M L   `   `   `  ����S  OCalviArceDavidArielFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:CalviArceDavidArielFinalCalviArceDavidArielFinal  5   	   )    #CalviArceDavidArielFinal.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:CalviArceDavidArielFinal     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5        $	��850��5   	   $
��1200��6     � WindowStartupLocation$  CenterScreen=�6#    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�6    � AllowsTransparency . ��62   Z� .��5      � .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��10q�6      UniformCornerRadius$ 15Q�6*   .��5      �  � ColumnDefinitions 5      �� 5      $��1* �6'   �� 5      $	��15* �6'    � 	Resources 5      '  !MaterialDesignThemes.Wpf.PackIcon �� 
TargetType �� Property	 �� Value��%�   '        �� 5      "  6   .�5      ��  � ��$	 30��62   6?   �� 5       � ��$	 30��63   6@   5      5      .+�5      � $��0��6   .+�5      �� $
��0 15q�6   .@�5      �� $��Center=�6'   $
��0 10q�6D   .��5      �� -   5        
 ��Name$
 btnUser��5   %    &  "MaterialDesignFloatingActionButton#��[  66   $
��Left=�6r   
���   ���5      Z� ��65   Z� .��5   "   �� $��-5q�6-   .+�5   &        Kind$
 User=�6>   5   #   5       5!      �� 5"      $��Center=�6'   $��0q�6D   .��5#      �� #��[  6%   $
��Left=�6a   
���   ���5$      Z� ��65   Z� .��5%   "   �� $��-5q�6-   .+�5&   &     $ Teleconference=�6>   5'   #   5(      5)      �� 5+      $��Center=�6'   $��0 60 0 0q�6D   .��5,      �� -   5        $
 btnExit��5-   ^   #��[  5,   %   $
��Left=�6a   
���   ���5-      Z� ��65   Z� .��5.   "   �� $��-5q�6-   .+�5/   &     $ 	ExitToApp=�6>   50   #   51      52      53      54      � 55      -   5        $��RenderPages��55   <   $��1��6   ���#F6F5F857      58      59      5:      5;      