import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { Power1, Bounce } from 'gsap/all';
declare var TweenMax: any;

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  @ViewChild('gamelogo') box: ElementRef;

  constructor() { }

  ngOnInit() {
    this.animate();
  }

  animate(): void {
    TweenMax.fromTo('h1', 3, {x:300}, {x:10});
    TweenMax.fromTo('#p1', 2.4, {x:300}, {x:10});
    TweenMax.fromTo('#p2', 3.3, {x:300}, {x:10});
  }
}
