   M S B A M L   `   `   `  ����H  DMyMediaPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:MyMediaPlayer.viewModelsMyMediaPlayer.viewModels  5      )    #MyWindowsMediaPlayerV2.Views.MyView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFirstFloor.ModernUI, Version=1.0.6.0, Culture=neutral, PublicKeyToken=2d21ec3cd074c59a0mui&http://firstfloorsoftware.com/ModernUI  5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      /vm&clr-namespace:MyMediaPlayer.viewModels  5      $	��300��5
      .��5   
   �    ContentRoot#��[  6   .+�5   
   � .+�5      �   ContentMargin#��[ 6     � RowDefinitions  5      �� 5      �� 5      $
��Auto �6$   .+�5      r� -   5        $��	MediaElem��5       r� Source 5      ��  �� Path$ Media.CurrentMedia.Source� r� LoadedBehavior 5      �� *#!Media.CurrentMedia.LoadedBehavior+ �� Mode$ TwoWay=�5      � 5      $��1��6     StatusMargin#��[ 6$   .+�5      �� -   5        $��
SongSlider��5       � Value$ 0Q�5      $��Bottom=�5      $��0,0,0,21q�5       � Maximum 5      ��  �� ElementName$ 	MediaElem��$( "MediaElem.NaturalDuration.TimeSpan�5      5       5!      �� 5"      $
��Left=�6    �� Orientation$ 
Horizontal=�64   .+�5#      �� $
��Open��6   $��80��6J   $��Bottom=�6U   $
��Left=�6p   ��6(   �� $ OpenFile�6p   �� 5$      $
��Play��6   $��80��6J   $��Bottom=�6U   $
��Left=�6p   ��6(   �� $ PlayFile�6p   �� 5%      $��Pause��6   $��80��6L   $��Bottom=�6W   $
��Left=�6r   ��6)   �� $ 	PauseFile�6r   �� 5&      $
��Stop��6   $��80��6J   $��Bottom=�6U   $
��Left=�6p   ��6(   �� $ StopFile�6p   5'      5(      5)      5*      