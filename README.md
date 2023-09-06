# Layouts-in-.net-MAUI-ListView

This sample demonstrates how to create a custom layouts for a item to the .net MAUI ListView.

```
 <syncfusion:SfListView x:Name="listView" 
                                 SelectionMode="None" 
                                 Grid.Row="1"         
                                 ItemSize="240"
                                 ItemsSource="{Binding GalleryInfo}"                                  
                                 ScrollBarVisibility="Always">
            <syncfusion:SfListView.ItemTemplate>
                <DataTemplate>
                    <Grid >
                        <Grid.RowDefinitions>
                            <RowDefinition Height="200" />
                            <RowDefinition Height="40"/>
                        </Grid.RowDefinitions> 
                        <Image Source="{Binding Image,Converter={StaticResource ImageConverter}}" Aspect="AspectFill" />
                        <Label Text="{Binding ImageCount}" BackgroundColor="Grey"  TextColor="White" 
                                       VerticalTextAlignment="Center" VerticalOptions="End" />
                        <Label   Text="{Binding ImageTitle}" Grid.Row="1" 
                                    VerticalTextAlignment="Center" 
                                    VerticalOptions="Center" />
                    </Grid>
                </DataTemplate>
            </syncfusion:SfListView.ItemTemplate>  
        </syncfusion:SfListView>
```
## Requirements to run the demo

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.