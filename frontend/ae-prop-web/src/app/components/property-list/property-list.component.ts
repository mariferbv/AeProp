import { Component, inject, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PropertyService } from '../../services/property.service';
import {Property} from '../../models/property.model';

@Component({
  selector: 'app-property-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './property-list.component.html',
  styleUrl: './property-list.component.scss',
})
export class PropertyListComponent implements OnInit{
  private propertyService = inject(PropertyService);
  properties: Property[] = [];

  ngOnInit(): void {
    this.propertyService.getProperties().subscribe({
      next: (data) => 
        {this.properties = data;
          console.log('Fetched properties:', this.properties);
        },
      error: (err) => console.error('Error fetching properties:', err)
    })
  }
}
