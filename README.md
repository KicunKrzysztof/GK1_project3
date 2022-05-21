# GK1_project3
WinForms application with matrix filters for images

![alt text](https://github.com/KicunKrzysztof/GK1_project3/blob/master/gk3.jpg)

Project created for computer graphics university course, only for learning purposes.
It allow to load image, then the image is displayed in two copies. Left one is "original" and the right one changes after application of filter.
Additionaly, below images, there are RGB color histograms connected with right image.

## Menu
![alt text](https://github.com/KicunKrzysztof/GK1_project3/blob/master/gk3_menu.jpg)

On left panel there is several options:
### Image
- load file
- generate image

### Mode
- apply filter to whole image
- apply filter with brush
    - change size of brush with slider
- apply filter to drawed polygon
    - remove previous polygon

### Filters
- blur
- Gauss blur
- sharpening
- identity
- edge detection
- relief
- own filter
    - own filter factors

### Apply button
Click this button to apply filter to whole image or for polygon.

### Shift images
- shift right image to left spot (so you can apply next filter to right image)
- shift left image to right spot

### Modes examples
#### Brush
![alt text](https://github.com/KicunKrzysztof/GK1_project3/blob/master/gk3_brush.jpg)

#### Polygon
![alt text](https://github.com/KicunKrzysztof/GK1_project3/blob/master/gk3_polygon.jpg)
