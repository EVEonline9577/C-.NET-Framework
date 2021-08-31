package com.thebyteguru.main;

import com.thebyteguru.display.Display;
import com.thebyteguru.game.Game;

import javax.swing.AbstractAction;
import javax.swing.Timer;
import java.awt.event.ActionEvent;
//import java.util.Timer;

public class Main {

    public static void main(String[] args) {
	// write your code here
        Game tanks = new Game();
        tanks.start();



//        Display.create(800,600,"Tanks", 0xffAAffA0, 3);
//
//        Timer t = new Timer(1000/60 , new AbstractAction() {
//            @Override
//            public void actionPerformed(ActionEvent e) {
//                Display.clear();
//                Display.render();
//                Display.swapBuffers();
//            }
//        });
//        t.setRepeats(true);
//        t.start();

    }
}
