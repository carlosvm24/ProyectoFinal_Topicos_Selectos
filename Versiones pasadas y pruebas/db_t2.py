from tkinter import *
import tkinter as tk
import cx_Oracle


class Demo1:
    def __init__(self, master):
        self.master = master
        photo = tk.PhotoImage(file="Policía.png")
        self.frame = tk.Frame(self.master, padx=50, pady=50)
        userlabel = tk.Label(self.master, text='User Name:', bg = "black", fg = "white")
        self.master.user = tk.Entry(self.master, show='')
        pwdlabel = tk.Label(self.master, text='Password:', bg = "black", fg = "white")
        self.master.password = tk.Entry(self.master, show='*')
        giflabel = tk.Label(self.master, image = photo)
        #self.master.gif = tk.Entry(self.master, show='')
        #self.master.password.bind('<Return>', self.check_password)
        userlabel.pack(side=tk.TOP)
        self.master.user.pack(side=tk.TOP, padx=10, fill=tk.BOTH)
        pwdlabel.pack(side=tk.TOP)
        self.master.password.pack(side=tk.TOP, padx=10, fill=tk.BOTH)
        giflabel.image = photo
        #self.master.gif.pack(side=tk.TOP, padx=10, fill=tk.BOTH)
        b = tk.Button(self.master, borderwidth=7, text="Login", width=10, pady=6, command=self.check_password)
        b.pack(side=tk.BOTTOM)
        giflabel.pack(side=tk.BOTTOM)
        self.frame.pack()
        self.master.configure(background="black")

    def check_password(self):
        user_name = self.master.user.get()
        print(user_name)
        pwd = self.master.password.get()
        print(pwd)
        cur = con.cursor()
        lvl = cur.callfunc("CHECK_LOGIN", cx_Oracle.NUMBER, [user_name, pwd])
        if lvl == 1:
            cur.close()
            print('Logged In')
            self.new_window()
        else:
            return

    def new_window(self):
        self.master.destroy()
        root = tk.Tk()
        root.geometry('300x300')
        root.title('TIJUANA POLICE DEPARTMENT: CRIMINAL DATA BASE')
        app = Demo2(root)
        root.mainloop()

class Demo2:
    def __init__(self, master):
        self.master = master
        self.frame = tk.Frame(self.master, padx=50, pady=50)
        createButton = tk.Button(self.master, borderwidth=7, text="Create User", width=15, pady=6, command=self.new_user)
        editButton = tk.Button(self.master, borderwidth=7, text="Change Password", width=15, pady=6, command=self.edit_user)
        delButton = tk.Button(self.master, borderwidth=7, text="Delete User", width=15, pady=6, command=self.del_user)
        createButton.pack()
        editButton.pack()
        delButton.pack()
        self.frame.pack()

    def new_user(self):
        self.newWindow = tk.Toplevel(self.master)
        self.app = Demo3(self.newWindow)
        return
    def del_user(self):
        self.newWindow = tk.Toplevel(self.master)
        self.app = Demo4(self.newWindow)
        return
    def edit_user(self):
        self.newWindow = tk.Toplevel(self.master)
        self.app = Demo5(self.newWindow)
        return


class Demo3:
    def __init__(self, master):
        self.master = master
        self.frame = tk.Frame(self.master, padx=50, pady=50)
        userlabel = tk.Label(self.master, text='User Name:')
        self.master.user = tk.Entry(self.master, show='')
        ranklabel = tk.Label(self.master, text='Rank:')
        self.master.rank = tk.Entry(self.master, show='')
        lvllabel = tk.Label(self.master, text='Level:')
        self.master.lvl = tk.Entry(self.master, show='')
        # self.master.password.bind('<Return>', self.check_password)
        userlabel.pack(side=tk.TOP)
        self.master.user.pack(side=tk.TOP, padx=10, fill=tk.BOTH)
        ranklabel.pack(side=tk.TOP)
        self.master.rank.pack(side=tk.TOP, padx=10, fill=tk.BOTH)
        lvllabel.pack(side=tk.TOP)
        self.master.lvl.pack(side=tk.TOP, padx=10, fill=tk.BOTH)
        b = tk.Button(self.master, borderwidth=7, text="Add", width=10, pady=6, command=self.close_windows)
        b.pack(side=tk.BOTTOM)
        self.frame.pack()

    def close_windows(self):
        user_name = self.master.user.get()
        print(user_name)
        rank = self.master.rank.get()
        print(rank)
        lvl = self.master.lvl.get()
        print(lvl)
        cur = con.cursor()
        cur.callproc("LVL1.ADD_USER", [user_name, rank, lvl])
        cur.close()
        print('User Added')
        self.master.destroy()

class Demo4:
    def __init__(self, master):
        self.master = master
        self.frame = tk.Frame(self.master, padx=50, pady=50)
        userlabel = tk.Label(self.master, text='User Name:')
        self.master.user = tk.Entry(self.master, show='')
        userlabel.pack(side=tk.TOP)
        self.master.user.pack(side=tk.TOP, padx=10, fill=tk.BOTH)
        b = tk.Button(self.master, borderwidth=7, text="Delete", width=10, pady=6, command=self.close_windows)
        b.pack(side=tk.BOTTOM)
        self.frame.pack()

    def close_windows(self):
        user_name = self.master.user.get()
        print(user_name)
        cur = con.cursor()
        cur.callproc("LVL1.DELETE_USER", [user_name])
        print('User Deleted')
        self.master.destroy()

class Demo5:
    def __init__(self, master):
        self.master = master
        self.frame = tk.Frame(self.master, padx=50, pady=50)
        userlabel = tk.Label(self.master, text='User Name:')
        self.master.user = tk.Entry(self.master, show='')
        pwdlabel = tk.Label(self.master, text='Password:')
        self.master.pwd = tk.Entry(self.master, show='*')
        pwdlabel.pack(side=tk.TOP)
        self.master.pwd.pack(side=tk.TOP, padx=10, fill=tk.BOTH)
        userlabel.pack(side=tk.TOP)
        self.master.user.pack(side=tk.TOP, padx=10, fill=tk.BOTH)
        b = tk.Button(self.master, borderwidth=7, text="Change Password", width=15, pady=6, command=self.close_windows)
        b.pack(side=tk.BOTTOM)
        self.frame.pack()

    def close_windows(self):
        pwd = self.master.pwd.get()
        print(pwd)
        user_name = self.master.user.get()
        print(user_name)
        cur = con.cursor()
        cur.callproc("LVL1.EDIT_PWD", [pwd, user_name])
        print('Password Changed')
        self.master.destroy()

def main():
    global con
    con = cx_Oracle.connect('TJPD/Criminal2511@TJPD')
    root = tk.Tk()
    root.geometry('300x350')
    root.title('TIJUANA POLICE DEPARTMENT: CRIMINAL DATA BASE')
    app = Demo1(root)
    root.mainloop()


main()