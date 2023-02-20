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

fn = os.path.join('twinkle_little_star.xml')
# route = "C:\Users\alexl\Documents\github\University_Research\musicxml_test\twinkle_little_star.xml"

with open(fn, 'r') as stream:
    xml_str = stream.read()

start = xml_str.find('<note')
end = xml_str[start:].find('</note>') + start + len('</note>')
print(xml_str[start:end])