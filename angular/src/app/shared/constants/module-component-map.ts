import { TABS } from '../constants/tab-keys';

export const MODULE_PATHS = {
    // TODO: Review Code. Duplicated declaration.
    APP_ADMIN_ADMIN_MODULE: 'app/admin/admin.module',


    APP_STUDENT_MODULE: 'app/admin/dormitory/student/student.module',
    APP_BUILDING_ROOM_MODULE: 'app/admin/dormitory/building-room/building-room.module',
    APP_INVOICE_MODULE: 'app/admin/dormitory/invoice/invoice.module',
    APP_INBILL_MODULE: 'app/admin/dormitory/in-bill/in-bill.module',
    APP_OUTBILL_MODULE: 'app/admin/dormitory/out-bill/out-bill.module',
    APP_CONTRACT_MODULE: 'app/admin/dormitory/contract/contract.module',


};

export const MODULE_COMPONENT_MAP = {
    [MODULE_PATHS.APP_ADMIN_ADMIN_MODULE]: [
        TABS.ADMIN_ORGANIZATION_UNITS,
        TABS.ADMIN_USERS,
        TABS.ADMIN_ROLES,
    ],
  [MODULE_PATHS.APP_STUDENT_MODULE]: [TABS.STUDENT],
  [MODULE_PATHS.APP_BUILDING_ROOM_MODULE]: [TABS.BUILDING_ROOM],
  [MODULE_PATHS.APP_INVOICE_MODULE]: [TABS.INVOICE],
  [MODULE_PATHS.APP_INBILL_MODULE]: [TABS.INBILL],
  [MODULE_PATHS.APP_OUTBILL_MODULE]: [TABS.OUTBILL],
  [MODULE_PATHS.APP_CONTRACT_MODULE]: [TABS.CONTRACT],



};
