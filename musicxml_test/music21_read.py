import sys
import os

import numpy as np
from matplotlib import pyplot as plt
from matplotlib import patches
import pandas as pd
import IPython.display as ipd
import music21 as m21

sys.path.append('..')
import libfmp.c1

music_name = "twinkle_little_star.xml"

ABS_PATH = "C:\\Users\\alexl\\Documents\\github\\University_Research\\musicxml_test\\"
fn = ABS_PATH + music_name

with open(fn, 'r') as stream:
    xml_str = stream.read()

start = xml_str.find('<note')
end = xml_str[start:].find('</note>') + start + len('</note>')
print(xml_str[start:end])