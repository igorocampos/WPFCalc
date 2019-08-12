# WPFCalc
This project is a Simple Calculator made using WPF and Class Abstraction on the operations. It is more of a tutorial for those starting with WPF, especially those who are migrating from WinForms.  

![](WPFCalc.png)

# What will you need
This project was initially made using
- Visual Studio 2015
- .NET Framework 4.5.2

But it was updated to 
- Visual Studio 2019
- .NET Framework 4.8

Basically only the target framework was updated, so if you really need, you can downgrade it back to your version instead of using the latest version.

# Getting started
First of all open Visual Studio and Create a new project and select New WPF Application.
There should be now inside your project a file named `MainWindow.xaml`. This file is the WPF version of WinForms `designer` file. It is a markup file, where we can change some attributes in order to set the design of the ~~form~~ window and its components as we want.

For example in the opening tag of `Window`, we could change the attribute `Title` to `WPF Calculator`, set the `Width` and `Height` that we want and even set the Window startup location.

```xaml
Title="WPF Calculator" 
Height="400" 
Width="280" 
WindowStartupLocation="CenterScreen"
```

Alternatively, you can use Visual Studio to change the `XAML` file for you, just select the `Window` tag and press `F4`, or your personal shortcut, to open `Properties window`. There you will have all the settings about the `Window`.

These properties can also be changed by code after the `InitializeComponent` method call. This part of the code will be in the constructor of `MainWindow` class, you can reach it opening the file named `MainWindow.xaml.cs`, or usually just pressing the shortcut `F7` while having`MainWindow.xaml` opened on the screen.

# Let's get to it
If you come from `WinForms` type of design you would rather insert a bunch of buttons inside this `Window` thing, setting their position and size. However WPF would accept it, Here we will use more of a responsive way, in other words, when our calculator window gets stretched we want all buttons to follow it. This is a little bit different than `Anchoring` in `WinForms` since we want all buttons to stretch equally and without overlaying each other.

## Grid
The component that we need to get it done is called `Grid` and we can insert it as easy as typing `<Grid></Grid>` inside the `Window` tag.

After that, we want to set the Rows and Columns definitions, as below:
```xaml
<Grid.RowDefinitions>
    <RowDefinition Height="40"/>
    <RowDefinition Height="*"/>
    <RowDefinition Height="*"/>
    <RowDefinition Height="*"/>
    <RowDefinition Height="*"/>
    <RowDefinition Height="*"/>
</Grid.RowDefinitions>
<Grid.ColumnDefinitions>
    <ColumnDefinition Width="*"/>
    <ColumnDefinition Width="*"/>
    <ColumnDefinition Width="*"/>
    <ColumnDefinition Width="*"/>
</Grid.ColumnDefinitions>
```
Here we said that we want 6 rows and 4 columns in our grid, and all columns should have the same width dividing the total width of the Grid equally. Same for the rows height, except the first one, wich will have a fixed height of `40`. We will use this row for our Textbox.

Just like the `Window`, this `Grid` component properties can be changed by Visual Studio in the Properties window.

## Textbox
Ok, now we can insert all our visual components inside this grid. First, let's add a `Textbox` that will work as our calculator's display.

```xaml
<TextBox x:Name="txtInput" Grid.Row="0" Grid.ColumnSpan="4" Margin="2" TextAlignment="Right" Text="0" FontSize="20" IsReadOnly="True"/>
```
 In this we are saying that:
- Our `TextBox` should be named `txtInput`
- Its row position should be the first one (position `0`)
- It should Span for 4 columns
- It should have a margin of `2` in every direction
- Its text aligment should be to the right
- Its default text should be `"0"`
- The text font size should be `20`
- Finally it should be a read-only Textbox.

Again all this could also be set in the Properties window, but for me editing the XAML is so much easier!

## Number buttons
Now, pretty much the same for the number buttons:
```xaml
<Button x:Name="btn7" Content="7" Grid.Row="2" Grid.Column="0" FontSize="20" Margin="2" />
<Button x:Name="btn8" Content="8" Grid.Row="2" Grid.Column="1" FontSize="20" Margin="2" />
<Button x:Name="btn9" Content="9" Grid.Row="2" Grid.Column="2" FontSize="20" Margin="2" />
<Button x:Name="btn4" Content="4" Grid.Row="3" Grid.Column="0" FontSize="20" Margin="2" />
<Button x:Name="btn5" Content="5" Grid.Row="3" Grid.Column="1" FontSize="20" Margin="2" />
<Button x:Name="btn6" Content="6" Grid.Row="3" Grid.Column="2" FontSize="20" Margin="2" />
<Button x:Name="btn1" Content="1" Grid.Row="4" Grid.Column="0" FontSize="20" Margin="2" />
<Button x:Name="btn2" Content="2" Grid.Row="4" Grid.Column="1" FontSize="20" Margin="2" />
<Button x:Name="btn3" Content="3" Grid.Row="4" Grid.Column="2" FontSize="20" Margin="2" />
<Button x:Name="btn0" Content="0" Grid.Row="5" Grid.Column="0" FontSize="20" Margin="2" />
```
There is no `Text` property in a WPF Button, instead we use its `Content` property.

## Other buttons
We will finish our design by adding the remaining buttons:
```xaml
<Button x:Name="btnPoint" Content="." Grid.Row="5" Grid.Column="1" FontSize="20" Margin="2" />
<Button x:Name="btnDivision" Content="/" Grid.Row="1" Grid.Column="3" FontSize="20" Margin="2" />
<Button x:Name="btnMultiplication" Content="*" Grid.Row="2" Grid.Column="3" FontSize="20" Margin="2" />
<Button x:Name="btnSum" Content="+" Grid.Row="3" Grid.Column="4" FontSize="20" Margin="2" />
<Button x:Name="btnSubtraction" Content="-" Grid.Row="4" Grid.Column="3" FontSize="20" Margin="2" />
<Button x:Name="btnEquals" Content="=" Grid.Row="5" Grid.Column="2" FontSize="20" Margin="2" Grid.ColumnSpan="2" />
<Button x:Name="btnBack" Content="←" Grid.Row="1" Grid.Column="0" FontSize="20" Margin="2" />
<Button x:Name="btnClearEntry" Content="CE" Grid.Row="1" Grid.Column="1" FontSize="20" Margin="2" />
<Button x:Name="btnClearAll" Content="C" Grid.Row="1" Grid.Column="2" FontSize="20" Margin="2" />
```


# Future features

## Unit Tests
In the near future, I will include some Unit Tests for the operations.
 
## Porting to .NET Core 3.0
For now, Visual Studio 2019 only supports the WPF Designer in .NET Framework projects. I have the intention to port this project as soon as Visual Studio starts to support WPF Designer in .NET Core. However, if you wish to do it sooner, there is a workaround explained [here](https://docs.microsoft.com/en-us/dotnet/core/porting/wpf#wpf-designer).
