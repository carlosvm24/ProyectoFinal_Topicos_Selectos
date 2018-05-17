import sys

try:
    from Tkinter import *
except ImportError:
    from tkinter import *

try:
    import ttk
    py3 = False
except ImportError:
    import tkinter.ttk as ttk
    py3 = True

#import login_support


def vp_start_gui():
    '''Starting point when module is the main routine.'''
    global val, w, root
    root = Tk()
    style = ttk.Style(root)
    print(style.theme_names())
    style.theme_use('vista')
    top = TJPD (root)
    #login_support.init(root, top)
    root.mainloop()

w = None
def create_TJPD(root, *args, **kwargs):
    '''Starting point when module is imported by another program.'''
    global w, w_win, rt
    rt = root
    w = Toplevel (root)
    top = TJPD (w)
    #login_support.init(w, top, *args, **kwargs)
    return (w, top)

def destroy_TJPD():
    global w
    w.destroy()
    w = None


class TJPD:
    def __init__(self, top=None):
        '''This class configures and populates the toplevel window.
           top is the toplevel containing window.'''
        _bgcolor = '#d9d9d9'  # X11 color: 'gray85'
        _fgcolor = '#000000'  # X11 color: 'black'
        _compcolor = '#d9d9d9' # X11 color: 'gray85'
        _ana1color = '#d9d9d9' # X11 color: 'gray85'
        _ana2color = '#d9d9d9' # X11 color: 'gray85'

        top.geometry("450x400+564+139")
        top.title("TJPD")
        top.configure(background="#d9d9d9")



        self.Button1 = Button(top)
        self.Button1.place(relx=0.53, rely=0.85, height=40, width=170)
        self.Button1.configure(activebackground="#d9d9d9")
        self.Button1.configure(activeforeground="#000000")
        self.Button1.configure(background="#d9d9d9")
        self.Button1.configure(disabledforeground="#a3a3a3")
        self.Button1.configure(foreground="#000000")
        self.Button1.configure(highlightbackground="#d9d9d9")
        self.Button1.configure(highlightcolor="black")
        self.Button1.configure(pady="0")
        self.Button1.configure(text='''Button''')
        self.Button1.configure(width=170)

        self.Label1 = Label(top)
        self.Label1.place(relx=0.49, rely=0.57, height=26, width=71)
        self.Label1.configure(background="#d9d9d9")
        self.Label1.configure(disabledforeground="#a3a3a3")
        self.Label1.configure(foreground="#000000")
        self.Label1.configure(text='''Password:''')

        self.Entry1 = Entry(top)
        self.Entry1.place(relx=0.48, rely=0.68,height=24, relwidth=0.48)
        self.Entry1.configure(background="white")
        self.Entry1.configure(disabledforeground="#a3a3a3")
        self.Entry1.configure(font="TkFixedFont")
        self.Entry1.configure(foreground="#000000")
        self.Entry1.configure(insertbackground="black")
        self.Entry1.configure(width=214)

        self.Label2 = Label(top)
        self.Label2.place(relx=0.49, rely=0.25, height=26, width=82)
        self.Label2.configure(background="#d9d9d9")
        self.Label2.configure(disabledforeground="#a3a3a3")
        self.Label2.configure(foreground="#000000")
        self.Label2.configure(text='''Username:''')
        self.Label2.configure(width=82)

        self.Entry2 = Entry(top)
        self.Entry2.place(relx=0.49, rely=0.33,height=24, relwidth=0.48)
        self.Entry2.configure(background="white")
        self.Entry2.configure(disabledforeground="#a3a3a3")
        self.Entry2.configure(font="TkFixedFont")
        self.Entry2.configure(foreground="#000000")
        self.Entry2.configure(insertbackground="black")
        self.Entry2.configure(width=214)

        self.Frame1 = Frame(top)
        self.Frame1.place(relx=0.02, rely=0.25, relheight=0.5, relwidth=0.44)
        self.Frame1.configure(relief=GROOVE)
        self.Frame1.configure(borderwidth="2")
        self.Frame1.configure(relief=GROOVE)
        self.Frame1.configure(background="#d9d9d9")
        self.Frame1.configure(width=145)

if __name__ == '__main__':
    vp_start_gui()
