# Phone2Paper

A convenient software to expose photo paper directly from the phone display.

The software runs on a Windows PC or notebook. The exposure of the photo paper is done by a cell phone display, which is either projected by a lens of an enlarger or directly in contact to the photo paper. A second tablet or mobile phone can be used as an interface.

![Overview](https://raw.githubusercontent.com/CodeKek/Phone2Paper/master/Overview.jpg)

On the tablet, an image can be selected from a PC folder. The image is flipped, converted to grayscale and shown on the cell phone display for an adjustable exposure time. The image can be scaled, positioned and rotated as desired. In addition, the gamma value can be changed to work with paper of different hardness. With a built-in calibration function an exposure series with different times as well as different gamma values can be run. The software creates a log file in which an entry with time stamp, image file name, exposure time, gamma value and zoom values are stored for each print. In case you are not satisfied with a picture, you can track the exposure parameters and correct them accordingly.

Of course, the quality of the pictures stands and falls with the resolution of the cell phone display. The sharpness of prints from negative films is not achieved, especially with larger formats, but depending on the requirements and intended use, very decent prints can be made from digital images quite comfortably. Especially zooming into an image is done with a few clicks, without having to change the distance and thus the exposure time.

## Installation

The software runs under Windows and can be downloaded [here](https://github.com/CodeKek/Phone2Paper/blob/master/Phone2Paper.exe). Alternatively, the source code is available for your own customizations.

To connect cell phone and tablet, the software Spacedesk must be installed on both PC and cell phone (Android or iPhone). Download and instructions [here](https://www.spacedesk.net/de/).

## Preparation

The biggest challenge is projecting the cell phone dispay onto the photo paper. On my old medium format enlarger, the top attachment with lamp can be removed and the cell phone simply placed on top.

Once the Spacedesk drivers and apps are installed, the Phone2Paper software is launched. A small main window appears, the red and black interface window and the exposure window. The latter two windows are moved to the respective devices and maximized by clicking in the main window.

For the cell phone, the following settings are useful:

 * Spacedesk image quality to maximum
 * Hide Spacedesk Menu
 * Screen brightness to maximum
 * Turn off notifications

With the tablet, only the brightness should be reduced to a minimum.

If the Windows PC is in the darkroom, the monitors should be switched off. Since all three devices communicate via WLAN, the PC can of course also be located outside.

Now the lights can be turned off in the darkroom and the fun can begin.

## Exposure

The software is (hopefully) self-explanatory. At the top of the screen, there are three buttons that show different pages:

### Image

Here you can load an image from a folder on your PC. With the buttons on the left and right you can scroll through the directory.

### Exposure

Exposure time, gamma value (image hardness), zoom factor and image position are set here. The exposure can either be tested (display always on) or automatically timed.

### Calibrate

The software can generate exposure and gamma series. The exposure pattern can also be adjusted in size and position and tested beforehand.

![Belichtungsreihe](https://github.com/CodeKek/Phone2Paper/blob/master/B-Reihe.jpg)

