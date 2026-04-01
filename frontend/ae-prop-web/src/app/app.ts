import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { PropertyListComponent } from './components/property-list/property-list.component';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, PropertyListComponent],
  templateUrl: './app.html',
  styleUrl: './app.scss'
})
export class App {
  protected readonly title = signal('ae-prop-web');
}
