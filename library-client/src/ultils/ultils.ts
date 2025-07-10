export enum BookStatus {
  Available = 'Available',
  Borrowed = 'Borrowed',
  Reserved = 'Reserved',
  Maintenance = 'Maintenance',
}

export type BadgeVariant = 'default' | 'destructive' | 'secondary'

export const getVariantsForBookStatus = (status: BookStatus | string): BadgeVariant => {
  switch (status) {
    case BookStatus.Available:
      return 'default'
    case BookStatus.Borrowed:
      return 'destructive'
    default:
      return 'secondary'
  }
}
